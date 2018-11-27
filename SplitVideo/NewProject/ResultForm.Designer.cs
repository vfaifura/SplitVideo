namespace SplitVideo.NewProject
{
    partial class ResultForm
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
            this.expectedGrid = new System.Windows.Forms.DataGridView();
            this.fromColEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toColEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emotionColEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actualGrid = new System.Windows.Forms.DataGridView();
            this.timeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emotionColAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphGrid = new System.Windows.Forms.DataGridView();
            this.emotionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attentionRateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matchedEmotionRateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expectedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // expectedGrid
            // 
            this.expectedGrid.AllowUserToAddRows = false;
            this.expectedGrid.AllowUserToDeleteRows = false;
            this.expectedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expectedGrid.BackgroundColor = System.Drawing.Color.White;
            this.expectedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expectedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColEx,
            this.toColEx,
            this.emotionColEx});
            this.expectedGrid.Location = new System.Drawing.Point(14, 40);
            this.expectedGrid.Margin = new System.Windows.Forms.Padding(5);
            this.expectedGrid.Name = "expectedGrid";
            this.expectedGrid.ReadOnly = true;
            this.expectedGrid.RowHeadersVisible = false;
            this.expectedGrid.Size = new System.Drawing.Size(443, 160);
            this.expectedGrid.TabIndex = 0;
            // 
            // fromColEx
            // 
            this.fromColEx.HeaderText = "from";
            this.fromColEx.Name = "fromColEx";
            this.fromColEx.ReadOnly = true;
            // 
            // toColEx
            // 
            this.toColEx.HeaderText = "to";
            this.toColEx.Name = "toColEx";
            this.toColEx.ReadOnly = true;
            // 
            // emotionColEx
            // 
            this.emotionColEx.HeaderText = "Emotion";
            this.emotionColEx.Name = "emotionColEx";
            this.emotionColEx.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expected result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actual result";
            // 
            // actualGrid
            // 
            this.actualGrid.AllowUserToAddRows = false;
            this.actualGrid.AllowUserToDeleteRows = false;
            this.actualGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actualGrid.BackgroundColor = System.Drawing.Color.White;
            this.actualGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actualGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeCol,
            this.emotionColAct});
            this.actualGrid.Location = new System.Drawing.Point(467, 35);
            this.actualGrid.Margin = new System.Windows.Forms.Padding(5);
            this.actualGrid.Name = "actualGrid";
            this.actualGrid.ReadOnly = true;
            this.actualGrid.RowHeadersVisible = false;
            this.actualGrid.Size = new System.Drawing.Size(443, 165);
            this.actualGrid.TabIndex = 2;
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time Index";
            this.timeCol.Name = "timeCol";
            this.timeCol.ReadOnly = true;
            // 
            // emotionColAct
            // 
            this.emotionColAct.HeaderText = "Emotion";
            this.emotionColAct.Name = "emotionColAct";
            this.emotionColAct.ReadOnly = true;
            // 
            // graphGrid
            // 
            this.graphGrid.AllowUserToAddRows = false;
            this.graphGrid.AllowUserToDeleteRows = false;
            this.graphGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.graphGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.graphGrid.BackgroundColor = System.Drawing.Color.White;
            this.graphGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graphGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.graphGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.graphGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graphGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emotionCol});
            this.graphGrid.Location = new System.Drawing.Point(14, 260);
            this.graphGrid.Name = "graphGrid";
            this.graphGrid.ReadOnly = true;
            this.graphGrid.RowHeadersVisible = false;
            this.graphGrid.Size = new System.Drawing.Size(896, 137);
            this.graphGrid.TabIndex = 4;
            // 
            // emotionCol
            // 
            this.emotionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emotionCol.HeaderText = "Emotion";
            this.emotionCol.MinimumWidth = 50;
            this.emotionCol.Name = "emotionCol";
            this.emotionCol.ReadOnly = true;
            this.emotionCol.Width = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emotion Graph";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total attention rate:";
            // 
            // attentionRateLabel
            // 
            this.attentionRateLabel.AutoSize = true;
            this.attentionRateLabel.BackColor = System.Drawing.Color.White;
            this.attentionRateLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.attentionRateLabel.Location = new System.Drawing.Point(193, 411);
            this.attentionRateLabel.Name = "attentionRateLabel";
            this.attentionRateLabel.Size = new System.Drawing.Size(181, 21);
            this.attentionRateLabel.TabIndex = 7;
            this.attentionRateLabel.Text = "Total attention rate %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resolution:";
            // 
            // matchedEmotionRateLabel
            // 
            this.matchedEmotionRateLabel.AutoSize = true;
            this.matchedEmotionRateLabel.BackColor = System.Drawing.Color.White;
            this.matchedEmotionRateLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.matchedEmotionRateLabel.Location = new System.Drawing.Point(586, 411);
            this.matchedEmotionRateLabel.Name = "matchedEmotionRateLabel";
            this.matchedEmotionRateLabel.Size = new System.Drawing.Size(212, 21);
            this.matchedEmotionRateLabel.TabIndex = 10;
            this.matchedEmotionRateLabel.Text = "Matched emotions rate %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Matched emotions rate:";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.BackColor = System.Drawing.Color.White;
            this.resolutionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.resolutionLabel.Location = new System.Drawing.Point(193, 442);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(93, 21);
            this.resolutionLabel.TabIndex = 11;
            this.resolutionLabel.Text = "Resolution ";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 472);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.matchedEmotionRateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attentionRateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graphGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expectedGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpectedActualResult";
            this.Load += new System.EventHandler(this.ExpectedActualResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expectedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView expectedGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromColEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn toColEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn emotionColEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView actualGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emotionColAct;
        private System.Windows.Forms.DataGridView graphGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emotionCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label attentionRateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label matchedEmotionRateLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resolutionLabel;
    }
}