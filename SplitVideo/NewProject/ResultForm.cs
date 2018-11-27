using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;

namespace SplitVideo.NewProject
{
    public partial class ResultForm : Form
    {
        private int matchedCount;
        private int matchedPercent;
        private readonly int expectedAttentionRate;

        // похибка
        private static int delta = 30;

        public ResultForm(int projectId)
        {
            matchedCount = 0;
            InitializeComponent();
            var worker = new ProjectWorker();
            var currentAttentionRate = worker.LoadResultToGrid(projectId, expectedGrid, actualGrid);
            BuildGraph();

            // обраховуємо % емоцій що співпали
            var totalCount = actualGrid.Rows.Count;
            matchedPercent = matchedCount * 100 / totalCount;

            // витягуємо з бази очікуваний % уваги
            this.expectedAttentionRate = worker.GetAttentionRate(projectId);

            // відображаєм в label
            this.attentionRateLabel.Text = $@"{currentAttentionRate}%";
            this.matchedEmotionRateLabel.Text = $@"{matchedPercent}%";

            if (currentAttentionRate >= expectedAttentionRate && matchedPercent >= 100 - delta)
            {
                resolutionLabel.Text = @"This project is eligeable to proceed";
            }
            else
            {
                resolutionLabel.Text = @"Project does not meet minimum requirements";
                resolutionLabel.ForeColor = Color.IndianRed;
            }
        }

        private void BuildGraph()
        {
            var seconds = Convert.ToInt32(actualGrid.Rows[actualGrid.Rows.Count - 1].Cells[0].Value);
            for (var i = 0; i <= seconds; i++)
            {
                var col = new DataGridViewColumn
                {
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    Name = $"col{i}",
                    HeaderText = i.ToString(),
                    CellTemplate = new DataGridViewTextBoxCell()
                };

                graphGrid.Columns.Add(col);
            }

            var emotions = new List<string>();
            foreach (DataGridViewRow row in actualGrid.Rows)
            {
                var emotion = row.Cells[1].Value.ToString();
                if (!emotions.Any(x => x.Equals(emotion)))
                {
                    emotions.Add(emotion);
                }
            }

            foreach (var emotion in emotions)
            {
                graphGrid.Rows.Add(emotion);
            }

            foreach (DataGridViewRow row in actualGrid.Rows)
            {
                var time = Convert.ToInt32(row.Cells[0].Value.ToString());
                var emotion = row.Cells[1].Value.ToString();

                var index = ExtractRowByEmotion(emotion);

                graphGrid.Rows[index].Cells[time + 1].Style.BackColor = Color.DeepSkyBlue;
            }

            foreach (DataGridViewRow graphGridRow in graphGrid.Rows)
            {
                var obtainedEmotion = graphGridRow.Cells[0].Value.ToString();
                foreach (DataGridViewCell cell in graphGridRow.Cells)
                {
                    if (cell.ColumnIndex == 0)
                        continue;

                    if (cell.Style.BackColor != Color.DeepSkyBlue)
                        continue;

                    var timeIndex = cell.ColumnIndex - 1;
                    var expectedEmotion = ExtractEmotionFromExpected(timeIndex);

                    if (obtainedEmotion != expectedEmotion)
                        cell.Style.BackColor = Color.IndianRed;
                    else
                    {
                        matchedCount++;
                    }
                }
            }
        }

        private string ExtractEmotionFromExpected(int timeIndex)
        {
            foreach (DataGridViewRow row in expectedGrid.Rows)
            {
                var time = Convert.ToInt32(row.Cells[0].Value);
                var end = Convert.ToInt32(row.Cells[1].Value);
                if (timeIndex >= time && timeIndex < end)
                    return row.Cells[2].Value.ToString();
            }

            return string.Empty;
        }

        private int ExtractRowByEmotion(string emotion)
        {
            foreach (DataGridViewRow row in graphGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(emotion))
                    return row.Index;
            }

            return 0;
        }

        private void ExpectedActualResult_Load(object sender, EventArgs e)
        {
            this.actualGrid.ClearSelection();
            this.graphGrid.ClearSelection();
            this.expectedGrid.ClearSelection();
        }
    }
}
