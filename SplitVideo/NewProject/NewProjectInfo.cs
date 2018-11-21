using System;
using System.Windows.Forms;
using EmotionMarketing.Domain;
using EmotionMarketing.Logic.DbWorker;
using EmotionMarketing.Logic.Utils;

namespace SplitVideo.NewProject
{
    public partial class NewProjectInfo : Form
    {
        private readonly ProjectWorker worker;

        public NewProjectInfo()
        {
            InitializeComponent();

            worker = new ProjectWorker();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            var gender = genreComboBox.Text == @"Male" ? GenderType.Male : GenderType.Female;
            var rate = (int)attentionRateNumeric.Value;

            worker.CreateProject(titleTextBox.Text, descriptionTextBox.Text,
                genreComboBox.Text, producerNameTextBox.Text, gender, rate);

            MessageSender.SuccessMessage("Project successfuly created");
            this.Dispose();
        }

        private void NewProjectInfo_Load(object sender, EventArgs e)
        {
            ComboBoxLoader.LoadGenreComboBox(ref genreComboBox);
        }
    }
}
