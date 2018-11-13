using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using SplitVideo.Shared;

namespace SplitVideo.NewProject
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();

            emotionColumn.Items.AddRange("Happy", "Mad", "Anger");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialod1 = new OpenFileDialog();

            if (openFileDialod1.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialod1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = filePath.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            var inputFile = new MediaFile { Filename = filePath.Text };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            metaDataRichTextBox.Text = inputFile.Metadata.Duration.TotalSeconds + Environment.NewLine + inputFile.Metadata.VideoData.Fps;  // info about video
        }
        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            filePath.Text = "";
            dataGridView1.Rows.Clear();
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
            var inputFile = new MediaFile { Filename = filePath.Text };


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
            var currentState = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            if (dataGridView1.Rows.Count <= 0)
            {
                dataGridView1.Rows.Add(currentState, "");
            }
            else
            {
                var last = dataGridView1.Rows[dataGridView1.RowCount - 1];
                if (!string.IsNullOrEmpty(last.Cells[1].Value.ToString()))
                {
                    dataGridView1.Rows.Add(currentState, "");
                }
                else
                {
                    last.Cells[1].Value = currentState;
                }
            }
        }
    }
}
