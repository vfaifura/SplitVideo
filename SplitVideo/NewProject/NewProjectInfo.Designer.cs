namespace SplitVideo.NewProject
{
    partial class NewProjectInfo
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
            ((System.ComponentModel.ISupportInitialize)(this.attentionRateNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(357, 29);
            this.titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 97);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(357, 105);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(11, 235);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(357, 32);
            this.genreComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producer Name";
            // 
            // producerNameTextBox
            // 
            this.producerNameTextBox.Location = new System.Drawing.Point(11, 300);
            this.producerNameTextBox.Name = "producerNameTextBox";
            this.producerNameTextBox.Size = new System.Drawing.Size(357, 29);
            this.producerNameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target gender";
            // 
            // targetAudienceTextBox
            // 
            this.targetAudienceTextBox.FormattingEnabled = true;
            this.targetAudienceTextBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.targetAudienceTextBox.Location = new System.Drawing.Point(11, 365);
            this.targetAudienceTextBox.Name = "targetAudienceTextBox";
            this.targetAudienceTextBox.Size = new System.Drawing.Size(357, 32);
            this.targetAudienceTextBox.TabIndex = 8;
            // 
            // nextStepButton
            // 
            this.nextStepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextStepButton.Location = new System.Drawing.Point(12, 440);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(358, 38);
            this.nextStepButton.TabIndex = 10;
            this.nextStepButton.Text = "Create";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // attentionRateNumeric
            // 
            this.attentionRateNumeric.Location = new System.Drawing.Point(209, 402);
            this.attentionRateNumeric.Name = "attentionRateNumeric";
            this.attentionRateNumeric.Size = new System.Drawing.Size(120, 29);
            this.attentionRateNumeric.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Attention rate:";
            // 
            // NewProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 483);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project Form";
            this.Load += new System.EventHandler(this.NewProjectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attentionRateNumeric)).EndInit();
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
    }
}