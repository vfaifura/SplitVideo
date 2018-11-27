using System;
using System.Windows.Forms;

namespace SplitVideo.Shared
{
    public partial class LoadForm : Form
    {
        private void UpdateProgress()
        {
            if (this.progressBar1.InvokeRequired)
            {

                this.Invoke(new Action(UpdateProgress));
            }
            else
            {
                if (progressBar1.Value + progressBar1.Step < progressBar1.Maximum)
                {
                    progressBar1.PerformStep();
                }
                else
                {
                    progressBar1.Value = 0;
                }
            }
        }

        public LoadForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProgress();
        }
    }
}
