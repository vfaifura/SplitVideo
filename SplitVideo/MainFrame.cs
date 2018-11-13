using System;
using System.Windows.Forms;
using SplitVideo.NewProject;

namespace SplitVideo
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void newProjectButton_Click(object sender, EventArgs e)
        {
            using (var form = new NewProjectInfo())
            {
                this.Hide();
                form.ShowDialog();
            }

            this.Show();
        }
    }
}
