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

        public void CreateProject(string title, string description, string genre,
                                  string producer, GenderType gender, int attentionRate)
        {
            using (var db = new emotionDb())
            {
                var genreInstance = db.Genres.FirstOrDefault(x => x.Name.Equals(genre));
                if (genreInstance == null)
                    return;

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
            }
        }

        public void LoadResultToGrid(int projectId, DataGridView expected, DataGridView actual)
        {
            using (var db = new emotionDb())
            {
                var project = db.Projects
                                .Include(x => x.ExpectedResults).ThenInclude(x => x.Emotion)
                                .Include(x => x.ActualResults).ThenInclude(x => x.Emotion)
                                .FirstOrDefault(x => x.Id.Equals(projectId));

                if (project == null)
                    return;

                foreach (var expectedResult in project.ExpectedResults)
                    expected.Rows.Add(expectedResult.From, expectedResult.To, expectedResult.Emotion.Name);

                foreach (var actualResult in project.ActualResults)
                {
                    actual.Rows.Add(actualResult.TimeIndex, actualResult.Emotion.Name);
                }

            }
        }
    }
}
