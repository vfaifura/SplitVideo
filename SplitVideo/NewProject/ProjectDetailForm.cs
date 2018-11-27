using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;
using EmotionMarketing.Logic.EmotionAPI;
using EmotionMarketing.Logic.Utils;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace SplitVideo.NewProject
{
    public partial class ProjectDetailForm : Form
    {
        private int projectId;
        private string fileName = "image-";

        public ProjectDetailForm(int projectId)
        {
            InitializeComponent();

            this.projectId = projectId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialod1 = new OpenFileDialog();

            if (openFileDialod1.ShowDialog() != DialogResult.OK)
                return;

            targetVideoPathTextBox.Text = openFileDialod1.FileName;

            targetVideo.URL = targetVideoPathTextBox.Text;
            targetVideo.Ctlcontrols.play();
            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }
        }

        private void setPathToReactionVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialod1 = new OpenFileDialog();

            if (openFileDialod1.ShowDialog() != DialogResult.OK)
                return;

            reactionVideoPathTextBox.Text = openFileDialod1.FileName;

            reactionVideo.URL = reactionVideoPathTextBox.Text;
            reactionVideo.Ctlcontrols.stop();
            var inputFile = new MediaFile { Filename = reactionVideoPathTextBox.Text };

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


        private async void processButton_ClickAsync(object sender, EventArgs e)
        {
            if (!this.Validatation())
                return;

            MessageSender.SuccessMessage("We starting to cut video");
            CutVideo();
            MessageSender.SuccessMessage("We're uploading to azure");
            await Extracting();

            DialogResult = DialogResult.OK;
        }

        private bool Validatation()
        {
            // validate empty path
            if (string.IsNullOrEmpty(targetVideoPathTextBox.Text))
            {
                MessageSender.ErrorMessage("Provide target video path");
                return false;
            }

            if (string.IsNullOrEmpty(reactionVideoPathTextBox.Text))
            {
                MessageSender.ErrorMessage("Provide reaction video path");
                return false;
            }

            // validate expected result input
            var lastRow = videoIntervalGrid.Rows[videoIntervalGrid.Rows.Count - 1];

            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            var totalSec = inputFile.Metadata.Duration.TotalSeconds;

            if (string.IsNullOrEmpty(lastRow.Cells[1].Value.ToString()))
            {
                lastRow.Cells[1].Value = totalSec;
            }


            return true;
        }

        private void CutVideo()
        {
            var inputFile = new MediaFile { Filename = reactionVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "frames");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                else
                {
                    var di = new DirectoryInfo(path);
                    foreach (var fileToRemove in di.GetFiles())
                    {
                        fileToRemove.Delete();
                    }
                }

                var i = 0;
                var durationDouble = Convert.ToDouble(inputFile
                                                      .Metadata.Duration.TotalSeconds
                                                      .ToString(CultureInfo.CurrentCulture)) + 0.005;

                var durationInt = (int)durationDouble;

                while (i <= durationInt)
                {
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(i) };
                    var outputFile = new MediaFile { Filename = $"{path}\\{fileName}{i}.jpeg" };
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

        private async Task Extracting()
        {
            var inputFile = new MediaFile { Filename = targetVideoPathTextBox.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            var totalSec = inputFile.Metadata.Duration.TotalSeconds;

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
                var fullPath = $"{path}/{fileName}{i}.jpeg";

                var emotionExtracter = new ExtractEmotionFromPicture();

                var emotion = await emotionExtracter.Process(fullPath);
                Thread.Sleep(500);

                // error handling
                if (emotion == null)
                    continue;

                var actualResultWorker = new ActualResultWorker();
                actualResultWorker.Create(emotion, this.projectId, i);
                logTextBox.AppendText($"{DateTime.Now} image processing, obtained emotion {emotion}{Environment.NewLine}");
            }
        }

        private void targetVideo_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState != 1) return;
            targetVideo.Ctlcontrols.currentPosition = targetVideo.currentMedia.duration;//- .001;
            targetVideo.Ctlcontrols.play();
            targetVideo.Ctlcontrols.pause();
        }
    }
}
