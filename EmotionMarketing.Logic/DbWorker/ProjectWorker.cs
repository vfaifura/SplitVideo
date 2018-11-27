using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmotionMarketing.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmotionMarketing.Logic.DbWorker
{
    public class ProjectWorker
    {
        public void LoadProjectToGrid(DataGridView dgv)
        {
            using (var db = new emotionDb())
            {
                var projects = db.Projects.Include(x => x.Genre).ToList();

                foreach (var project in projects)
                {
                    var genderType = project.GenderType == GenderType.Male ? "M" : "F";

                    dgv.Rows.Add(project.Id, project.Title, project.Description,
                    project.ProducerName, genderType, project.Genre.Name,
                    project.AttentionRate);
                }
            }
        }

        public int? CreateProject(string title, string description, string genre,
                                  string producer, GenderType gender, int attentionRate)
        {
            using (var db = new emotionDb())
            {
                var genreInstance = db.Genres.FirstOrDefault(x => x.Name.Equals(genre));
                if (genreInstance == null)
                    return null;

                var project = new Project
                {
                    Title = title,
                    Description = description,
                    Genre = genreInstance,
                    ProducerName = producer,
                    GenderType = gender,
                    AttentionRate = attentionRate
                };

                db.Add(project);
                db.SaveChanges();

                return project.Id;
            }
        }

        public int LoadResultToGrid(int projectId, DataGridView expected, DataGridView actual)
        {
            using (var db = new emotionDb())
            {
                var project = db.Projects
                                .Include(x => x.ExpectedResults).ThenInclude(x => x.Emotion)
                                .Include(x => x.ActualResults).ThenInclude(x => x.Emotion)
                                .FirstOrDefault(x => x.Id.Equals(projectId));

                if (project == null)
                    return 0;

                var totalSecs = project.ActualResults.OrderBy(x => x.TimeIndex).Last().TimeIndex;
                int noAttentionCount = 0;

                foreach (var expectedResult in project.ExpectedResults)
                    expected.Rows.Add(expectedResult.From, expectedResult.To, expectedResult.Emotion.Name);

                foreach (var actualResult in project.ActualResults.OrderBy(x => x.TimeIndex))
                {
                    actual.Rows.Add(actualResult.TimeIndex, actualResult.Emotion.Name);
                }

                foreach (DataGridViewRow row in expected.Rows)
                {
                    var endTime = Convert.ToInt32(row.Cells[1].Value);
                    var emotion = row.Cells[2].Value.ToString();
                    var isLast = row.Index == expected.Rows[expected.Rows.Count - 1].Index;
                    foreach (DataGridViewRow actualRow in actual.Rows)
                    {
                        var time = Convert.ToInt32(actualRow.Cells[0].Value);
                        var actEmotion = actualRow.Cells[1].Value;

                        if (time >= endTime && !isLast) break;

                        var color = actualRow.DefaultCellStyle.BackColor;
                        if (color != Color.DeepSkyBlue && color != Color.IndianRed)
                        {
                            actualRow.DefaultCellStyle.BackColor = emotion.Equals(actEmotion)
                                                                       ? Color.DeepSkyBlue
                                                                       : Color.IndianRed;
                        }

                        if (actEmotion.Equals("No attention"))
                        {
                            noAttentionCount++;
                        }
                    }
                }

                // к-ть секунду які було обличчя
                var currentAttentionRate = totalSecs - noAttentionCount;
                // калькуляція % уваги
                var attentionPercent = currentAttentionRate * 100 / totalSecs;
                return attentionPercent;
            }
        }

        public int GetAttentionRate(int projectId)
        {
            using (var db = new emotionDb())
            {
                var project = db.Projects.FirstOrDefault(x => x.Id.Equals(projectId));
                return project?.AttentionRate ?? 0;
            }
        }
    }
}
