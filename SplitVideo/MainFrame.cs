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
            using (var form = new CreateProjectForm())
            {
                this.Hide();

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    var id = form.projectId;
                    if (!id.HasValue) return;

                    using (var projectForm = new ProjectDetailForm(id.Value))
                    {
                        var res = projectForm.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            using (var resultForm = new ResultForm(id.Value))
                            {
                                resultForm.ShowDialog();
                            }
                        }
                    }
                }
            }

            this.Show();
        }

        private void viewProjectButton_Click(object sender, EventArgs e)
        {
            using (var form = new ProjectListForm())
            {
                this.Hide();
                form.ShowDialog();
            }

            this.Show();
        }
    }
}
