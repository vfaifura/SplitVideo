using System;
using System.Windows.Forms;
using EmotionMarketing.Domain;
using EmotionMarketing.Logic.DbWorker;
using EmotionMarketing.Logic.Utils;

namespace SplitVideo.NewProject
{
    public partial class CreateProjectForm : Form
    {
        public int? projectId;

        private readonly ProjectWorker worker;

        public CreateProjectForm()
        {
            InitializeComponent();

            worker = new ProjectWorker();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            var gender = genreComboBox.Text == @"Male" ? GenderType.Male : GenderType.Female;
            var rate = (int)attentionRateNumeric.Value;

            this.projectId = worker.CreateProject(titleTextBox.Text, descriptionTextBox.Text,
                genreComboBox.Text, producerNameTextBox.Text, gender, rate);

            MessageSender.SuccessMessage("Project successfuly created");
            DialogResult = DialogResult.OK;
        }

        private void NewProjectInfo_Load(object sender, EventArgs e)
        {
            ComboBoxLoader.LoadGenreComboBox(ref genreComboBox);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
