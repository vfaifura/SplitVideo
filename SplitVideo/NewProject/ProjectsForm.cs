using System;
using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;

namespace SplitVideo.NewProject
{
    public partial class ProjectsForm : Form
    {
        private readonly ProjectWorker worker;

        public ProjectsForm()
        {
            InitializeComponent();

            worker = new ProjectWorker();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            worker.LoadProjectToGrid(projectsGrid);
        }
    }
}
