using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;
using EmotionMarketing.Logic.EmotionAPI;
using EmotionMarketing.Logic.Utils;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using SplitVideo.Shared;

namespace SplitVideo.NewProject
{
    public partial class NewProjectForm : Form
    {
        private int projectId;

        public NewProjectForm(int projectId)
        {
            InitializeComponent();

            emotionColumn.Items.AddRange("Happy", "Mad", "Anger");
            this.projectId = projectId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialod1 = new OpenFileDialog();

            if (openFileDialod1.ShowDialog() == DialogResult.OK)
            {
                targetVideoPathTextBox.Text = openFileDialod1.FileName;
            }

            targetVideo.URL = targetVideoPathTextBox.Text;
            targetVideo.Ctlcontrols.play();
            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            targetVideo.Ctlcontrols.stop();
            targetVideoPathTextBox.Text = "";
            videoIntervalGrid.Rows.Clear();
        }


        private void processButton_Click(object sender, EventArgs e)
        {
            var form = new LoadForm();
            var th = new Thread(() =>
            {
                CutVideo();
                form.Dispose();
            });

            th.Start();
            form.Show();
        }

        private void CutVideo()
        {
            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "frames");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var i = 0;
                var durationDouble = Convert.ToDouble(inputFile
                                                      .Metadata.Duration.TotalSeconds
                                                      .ToString(CultureInfo.CurrentCulture));

                var durationInt = (int)durationDouble;

                while (i < durationInt)
                {
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(i) };
                    var outputFile = new MediaFile { Filename = $"{path}\\image--{i}.jpeg" };
                    engine.GetThumbnail(inputFile, outputFile, options);
                    i++;
                }

            }
        }

        private void getPlayerStateButton_Click(object sender, EventArgs e)
        {
            int currentState = (int)targetVideo.Ctlcontrols.currentPosition;

            if (videoIntervalGrid.Rows.Count <= 0)
            {
                videoIntervalGrid.Rows.Add(currentState, "");
            }
            else
            {
                var last = videoIntervalGrid.Rows[videoIntervalGrid.RowCount - 1];
                if (!string.IsNullOrEmpty(last.Cells[1].Value.ToString()))
                {
                    videoIntervalGrid.Rows.Add(currentState, "");
                }
                else
                {
                    last.Cells[1].Value = currentState;
                }
            }
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            this.videoIntervalGrid.Rows.Add("0", string.Empty, string.Empty);
            ComboBoxLoader.LoadEmotionComboBox(ref emotionColumn);
        }

        private async void extractEmotionButton(object sender, EventArgs e)
        {
            var lastRow = videoIntervalGrid.Rows[videoIntervalGrid.Rows.Count - 1];

            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            var totalSec = inputFile.Metadata.Duration.TotalSeconds;
           
            // todo fix me pls
            if (string.IsNullOrEmpty(lastRow.Cells[1].Value.ToString()))
            {
                lastRow.Cells[1].Value = inputFile.Metadata.Duration.ToString("mm:ss");
            }

            // validate grid input
            foreach (DataGridViewRow row in videoIntervalGrid.Rows)
            {
                if (
                    string.IsNullOrEmpty(row.Cells[0].Value.ToString()) ||
                    string.IsNullOrEmpty(row.Cells[1].Value.ToString()) ||
                    string.IsNullOrEmpty(row.Cells[2].Value.ToString())
                )
                {
                    MessageSender.ErrorMessage("You must fill expected grid");
                    return;
                }
            }

            // save expected result
            foreach (DataGridViewRow row in videoIntervalGrid.Rows)
            {
                var from = int.Parse(row.Cells[0].Value.ToString());
                var to = int.Parse(row.Cells[1].Value.ToString());
                var emotion = row.Cells[2].Value.ToString();

                var expectedResultWorker = new ExpectedResultWorker();
                expectedResultWorker.Create(this.projectId, from, to, emotion);
            }

            // store actual result
            for (var i = 0; i < totalSec; i++)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "frames");
                var fullPath = $"{path}/image--{i}.jpeg";

                var emotionExtracter = new ExtractEmotionFromPicture();

                var emotion = await emotionExtracter.Process(fullPath);

                var actualResultWorker = new ActualResultWorker();
                actualResultWorker.Create(emotion, this.projectId, i);
            }
        }
    }
}
