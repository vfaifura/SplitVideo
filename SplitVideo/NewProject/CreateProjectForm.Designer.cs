namespace SplitVideo.NewProject
{
    partial class CreateProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.producerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetAudienceTextBox = new System.Windows.Forms.ComboBox();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.attentionRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attentionRateNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titleTextBox.Location = new System.Drawing.Point(6, 81);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(357, 31);
            this.titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 138);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(720, 64);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(6, 232);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(263, 30);
            this.genreComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producer Name";
            // 
            // producerNameTextBox
            // 
            this.producerNameTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.producerNameTextBox.Location = new System.Drawing.Point(369, 81);
            this.producerNameTextBox.Name = "producerNameTextBox";
            this.producerNameTextBox.Size = new System.Drawing.Size(357, 31);
            this.producerNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target gender";
            // 
            // targetAudienceTextBox
            // 
            this.targetAudienceTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.targetAudienceTextBox.FormattingEnabled = true;
            this.targetAudienceTextBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.targetAudienceTextBox.Location = new System.Drawing.Point(275, 232);
            this.targetAudienceTextBox.Name = "targetAudienceTextBox";
            this.targetAudienceTextBox.Size = new System.Drawing.Size(269, 30);
            this.targetAudienceTextBox.TabIndex = 20;
            // 
            // nextStepButton
            // 
            this.nextStepButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nextStepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextStepButton.ForeColor = System.Drawing.Color.White;
            this.nextStepButton.Location = new System.Drawing.Point(491, 271);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(235, 35);
            this.nextStepButton.TabIndex = 35;
            this.nextStepButton.Text = "Create";
            this.nextStepButton.UseVisualStyleBackColor = false;
            this.nextStepButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // attentionRateNumeric
            // 
            this.attentionRateNumeric.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.attentionRateNumeric.Location = new System.Drawing.Point(550, 232);
            this.attentionRateNumeric.Name = "attentionRateNumeric";
            this.attentionRateNumeric.Size = new System.Drawing.Size(176, 31);
            this.attentionRateNumeric.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Attention rate:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 52);
            this.panel1.TabIndex = 15;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(685, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(44, 37);
            this.exitButton.TabIndex = 99999;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Emotion Marketing";
            // 
            // NewProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.attentionRateNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetAudienceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.producerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project Form";
            this.Load += new System.EventHandler(this.NewProjectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attentionRateNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox producerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox targetAudienceTextBox;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.NumericUpDown attentionRateNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label7;
    }
}