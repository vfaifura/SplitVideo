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
            this.setPathToTargetVideoButton = new System.Windows.Forms.Button();
            this.clearVideo = new System.Windows.Forms.Button();
            this.targetVideoPathTextBox = new System.Windows.Forms.TextBox();
            this.intoFramesButton = new System.Windows.Forms.Button();
            this.targetVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.videoIntervalGrid = new System.Windows.Forms.DataGridView();
            this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emotionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.getPlayerStateButton = new System.Windows.Forms.Button();
            this.reactionVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.reactionVideoPathTextBox = new System.Windows.Forms.TextBox();
            this.setPathToReactionVideoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.targetVideo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoIntervalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactionVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // setPathToTargetVideoButton
            // 
            this.setPathToTargetVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPathToTargetVideoButton.Location = new System.Drawing.Point(375, 34);
            this.setPathToTargetVideoButton.Margin = new System.Windows.Forms.Padding(5);
            this.setPathToTargetVideoButton.Name = "setPathToTargetVideoButton";
            this.setPathToTargetVideoButton.Size = new System.Drawing.Size(40, 30);
            this.setPathToTargetVideoButton.TabIndex = 1;
            this.setPathToTargetVideoButton.Text = "...";
            this.setPathToTargetVideoButton.UseVisualStyleBackColor = true;
            this.setPathToTargetVideoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearVideo
            // 
            this.clearVideo.Location = new System.Drawing.Point(20, 370);
            this.clearVideo.Margin = new System.Windows.Forms.Padding(5);
            this.clearVideo.Name = "clearVideo";
            this.clearVideo.Size = new System.Drawing.Size(125, 37);
            this.clearVideo.TabIndex = 3;
            this.clearVideo.Text = "Clear Video";
            this.clearVideo.UseVisualStyleBackColor = true;
            this.clearVideo.Click += new System.EventHandler(this.button3_Click);
            // 
            // targetVideoPathTextBox
            // 
            this.targetVideoPathTextBox.Location = new System.Drawing.Point(20, 34);
            this.targetVideoPathTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.targetVideoPathTextBox.Name = "targetVideoPathTextBox";
            this.targetVideoPathTextBox.Size = new System.Drawing.Size(345, 27);
            this.targetVideoPathTextBox.TabIndex = 4;
            // 
            // intoFramesButton
            // 
            this.intoFramesButton.Location = new System.Drawing.Point(456, 338);
            this.intoFramesButton.Margin = new System.Windows.Forms.Padding(5);
            this.intoFramesButton.Name = "intoFramesButton";
            this.intoFramesButton.Size = new System.Drawing.Size(343, 37);
            this.intoFramesButton.TabIndex = 5;
            this.intoFramesButton.Text = "3. Cut video on pic";
            this.intoFramesButton.UseVisualStyleBackColor = true;
            this.intoFramesButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // targetVideo
            // 
            this.targetVideo.Enabled = true;
            this.targetVideo.Location = new System.Drawing.Point(469, 19);
            this.targetVideo.Margin = new System.Windows.Forms.Padding(5);
            this.targetVideo.Name = "targetVideo";
            this.targetVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("targetVideo.OcxState")));
            this.targetVideo.Size = new System.Drawing.Size(433, 262);
            this.targetVideo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path to target video file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.videoIntervalGrid);
            this.groupBox1.Location = new System.Drawing.Point(20, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 235);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expected result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time interval";
            // 
            // videoIntervalGrid
            // 
            this.videoIntervalGrid.AllowUserToAddRows = false;
            this.videoIntervalGrid.AllowUserToDeleteRows = false;
            this.videoIntervalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.videoIntervalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoIntervalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColumn,
            this.toColumn,
            this.emotionColumn});
            this.videoIntervalGrid.Location = new System.Drawing.Point(10, 59);
            this.videoIntervalGrid.Name = "videoIntervalGrid";
            this.videoIntervalGrid.RowHeadersVisible = false;
            this.videoIntervalGrid.Size = new System.Drawing.Size(385, 162);
            this.videoIntervalGrid.TabIndex = 13;
            // 
            // fromColumn
            // 
            this.fromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fromColumn.HeaderText = "From";
            this.fromColumn.Name = "fromColumn";
            this.fromColumn.Width = 73;
            // 
            // toColumn
            // 
            this.toColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.toColumn.HeaderText = "To";
            this.toColumn.Name = "toColumn";
            this.toColumn.Width = 53;
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
            this.getPlayerStateButton.Location = new System.Drawing.Point(456, 291);
            this.getPlayerStateButton.Margin = new System.Windows.Forms.Padding(5);
            this.getPlayerStateButton.Name = "getPlayerStateButton";
            this.getPlayerStateButton.Size = new System.Drawing.Size(343, 37);
            this.getPlayerStateButton.TabIndex = 11;
            this.getPlayerStateButton.Text = "2. Get State";
            this.getPlayerStateButton.UseVisualStyleBackColor = true;
            this.getPlayerStateButton.Click += new System.EventHandler(this.getPlayerStateButton_Click);
            // 
            // reactionVideo
            // 
            this.reactionVideo.Enabled = true;
            this.reactionVideo.Location = new System.Drawing.Point(494, 19);
            this.reactionVideo.Margin = new System.Windows.Forms.Padding(5);
            this.reactionVideo.Name = "reactionVideo";
            this.reactionVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reactionVideo.OcxState")));
            this.reactionVideo.Size = new System.Drawing.Size(193, 166);
            this.reactionVideo.TabIndex = 12;
            this.reactionVideo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Path to reaction video file";
            // 
            // reactionVideoPathTextBox
            // 
            this.reactionVideoPathTextBox.Location = new System.Drawing.Point(20, 89);
            this.reactionVideoPathTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.reactionVideoPathTextBox.Name = "reactionVideoPathTextBox";
            this.reactionVideoPathTextBox.Size = new System.Drawing.Size(345, 27);
            this.reactionVideoPathTextBox.TabIndex = 16;
            // 
            // setPathToReactionVideoButton
            // 
            this.setPathToReactionVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPathToReactionVideoButton.Location = new System.Drawing.Point(375, 89);
            this.setPathToReactionVideoButton.Margin = new System.Windows.Forms.Padding(5);
            this.setPathToReactionVideoButton.Name = "setPathToReactionVideoButton";
            this.setPathToReactionVideoButton.Size = new System.Drawing.Size(40, 30);
            this.setPathToReactionVideoButton.TabIndex = 15;
            this.setPathToReactionVideoButton.Text = "...";
            this.setPathToReactionVideoButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "4. Send on azure and extract emotion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.extractEmotionButton);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reactionVideoPathTextBox);
            this.Controls.Add(this.setPathToReactionVideoButton);
            this.Controls.Add(this.getPlayerStateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intoFramesButton);
            this.Controls.Add(this.targetVideoPathTextBox);
            this.Controls.Add(this.clearVideo);
            this.Controls.Add(this.setPathToTargetVideoButton);
            this.Controls.Add(this.targetVideo);
            this.Controls.Add(this.reactionVideo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Setting Form";
            this.Load += new System.EventHandler(this.NewProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.targetVideo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoIntervalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactionVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer targetVideo;
        private System.Windows.Forms.Button setPathToTargetVideoButton;
        private System.Windows.Forms.Button clearVideo;
        private System.Windows.Forms.TextBox targetVideoPathTextBox;
        private System.Windows.Forms.Button intoFramesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView videoIntervalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn emotionColumn;
        private System.Windows.Forms.Button getPlayerStateButton;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer reactionVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reactionVideoPathTextBox;
        private System.Windows.Forms.Button setPathToReactionVideoButton;
        private System.Windows.Forms.Button button1;
    }
}

