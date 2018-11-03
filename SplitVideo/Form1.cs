using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit.Options;
using MediaToolkit.Util;
using MediaToolkit.Model;
using MediaToolkit;

namespace SplitVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialod1 = new OpenFileDialog();

            if (openFileDialod1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath.Text = openFileDialod1.FileName;
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

            metaDataRichTextBox.Text = inputFile.Metadata.Duration.TotalSeconds.ToString() + Environment.NewLine + inputFile.Metadata.VideoData.Fps.ToString();  // info about video
        }
        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.filePath.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: first remove all existing frames



            var inputFile = new MediaFile { Filename = filePath.Text };
            

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                var outputPath = @"C:\frames";
                var i = 0;
                int durationInt = 0;
                double durationDouble = 0;
                durationDouble = Convert.ToDouble(inputFile.Metadata.Duration.TotalSeconds.ToString());
                durationInt = (int)durationDouble;

                while (i < durationInt)
                {
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(i) };
                    var outputFile = new MediaFile { Filename = String.Format("{0}\\image--{1}.jpeg", outputPath, i) };
                    engine.GetThumbnail(inputFile, outputFile, options);
                    i++;
                }

            }

        }
    }
}
