using System;
using System.Windows.Forms;

namespace SplitVideo.Shared
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
}
