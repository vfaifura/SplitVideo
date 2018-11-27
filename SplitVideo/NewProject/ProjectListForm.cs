using System;
using System.Windows.Forms;
using EmotionMarketing.Logic.DbWorker;

namespace SplitVideo.NewProject
{
    public partial class ProjectListForm : Form
    {
        private readonly ProjectWorker worker;

        public ProjectListForm()
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

        private void projectsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var id = Convert.ToInt32(projectsGrid.Rows[e.RowIndex].Cells[0].Value);
            using (var form = new ResultForm(id))
            {
                form.ShowDialog();
            }
        }
    }
}
