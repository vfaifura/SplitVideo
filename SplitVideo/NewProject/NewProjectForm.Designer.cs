namespace SplitVideo.NewProject
{
    partial class NewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
            this.setPathToVideoButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearVideo = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.intoFramesButton = new System.Windows.Forms.Button();
            this.metaDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emotionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.getPlayerStateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // setPathToVideoButton
            // 
            this.setPathToVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPathToVideoButton.Location = new System.Drawing.Point(413, 36);
            this.setPathToVideoButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.setPathToVideoButton.Name = "setPathToVideoButton";
            this.setPathToVideoButton.Size = new System.Drawing.Size(44, 31);
            this.setPathToVideoButton.TabIndex = 1;
            this.setPathToVideoButton.Text = "...";
            this.setPathToVideoButton.UseVisualStyleBackColor = true;
            this.setPathToVideoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearVideo
            // 
            this.clearVideo.Location = new System.Drawing.Point(764, 469);
            this.clearVideo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clearVideo.Name = "clearVideo";
            this.clearVideo.Size = new System.Drawing.Size(138, 39);
            this.clearVideo.TabIndex = 3;
            this.clearVideo.Text = "Clear Video";
            this.clearVideo.UseVisualStyleBackColor = true;
            this.clearVideo.Click += new System.EventHandler(this.button3_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(22, 36);
            this.filePath.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(379, 31);
            this.filePath.TabIndex = 4;
            // 
            // intoFramesButton
            // 
            this.intoFramesButton.Location = new System.Drawing.Point(28, 469);
            this.intoFramesButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.intoFramesButton.Name = "intoFramesButton";
            this.intoFramesButton.Size = new System.Drawing.Size(435, 39);
            this.intoFramesButton.TabIndex = 5;
            this.intoFramesButton.Text = "Process";
            this.intoFramesButton.UseVisualStyleBackColor = true;
            this.intoFramesButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // metaDataRichTextBox
            // 
            this.metaDataRichTextBox.Location = new System.Drawing.Point(661, 373);
            this.metaDataRichTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.metaDataRichTextBox.Name = "metaDataRichTextBox";
            this.metaDataRichTextBox.Size = new System.Drawing.Size(241, 86);
            this.metaDataRichTextBox.TabIndex = 7;
            this.metaDataRichTextBox.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(476, 19);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(426, 317);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path to video file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 370);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expected result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Attention rate:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColumn,
            this.toColumn,
            this.emotionColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(423, 256);
            this.dataGridView1.TabIndex = 13;
            // 
            // fromColumn
            // 
            this.fromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fromColumn.HeaderText = "From";
            this.fromColumn.Name = "fromColumn";
            this.fromColumn.Width = 79;
            // 
            // toColumn
            // 
            this.toColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.toColumn.HeaderText = "To";
            this.toColumn.Name = "toColumn";
            this.toColumn.Width = 55;
            // 
            // emotionColumn
            // 
            this.emotionColumn.HeaderText = "Emotion";
            this.emotionColumn.Name = "emotionColumn";
            this.emotionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.emotionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // getPlayerStateButton
            // 
            this.getPlayerStateButton.Location = new System.Drawing.Point(476, 395);
            this.getPlayerStateButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.getPlayerStateButton.Name = "getPlayerStateButton";
            this.getPlayerStateButton.Size = new System.Drawing.Size(138, 39);
            this.getPlayerStateButton.TabIndex = 11;
            this.getPlayerStateButton.Text = "Get State";
            this.getPlayerStateButton.UseVisualStyleBackColor = true;
            this.getPlayerStateButton.Click += new System.EventHandler(this.getPlayerStateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Metadata";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getPlayerStateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metaDataRichTextBox);
            this.Controls.Add(this.intoFramesButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.clearVideo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.setPathToVideoButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Setting Form";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button setPathToVideoButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearVideo;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button intoFramesButton;
        private System.Windows.Forms.RichTextBox metaDataRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn emotionColumn;
        private System.Windows.Forms.Button getPlayerStateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

