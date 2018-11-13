using System;
using System.Windows.Forms;

namespace SplitVideo.NewProject
{
    public partial class NewProjectInfo : Form
    {
        public NewProjectInfo()
        {
            InitializeComponent();
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            using (var form = new NewProjectForm())
            {
                this.Hide();
                form.ShowDialog();
            }

            this.Dispose();
        }
    }
}
