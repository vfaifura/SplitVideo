using System;
using System.Windows.Forms;
using SplitVideo.NewProject;
using SplitVideo.Test;

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

        private void viewProjectButton_Click(object sender, EventArgs e)
        {
            using (var form = new ProjectsForm())
            {
                this.Hide();
                form.ShowDialog();
            }

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new NewProjectForm(1))
            {
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new ExpectedActualResult(1))
            {
                form.ShowDialog();
            }
        }
    }
}
