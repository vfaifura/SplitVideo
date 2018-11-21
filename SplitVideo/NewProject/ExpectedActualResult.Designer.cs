namespace SplitVideo.NewProject
{
    partial class ExpectedActualResult
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
            ((System.ComponentModel.ISupportInitialize)(this.expectedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // expectedGrid
            // 
            this.expectedGrid.AllowUserToAddRows = false;
            this.expectedGrid.AllowUserToDeleteRows = false;
            this.expectedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expectedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expectedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColEx,
            this.toColEx,
            this.emotionColEx});
            this.expectedGrid.Location = new System.Drawing.Point(14, 40);
            this.expectedGrid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.expectedGrid.Name = "expectedGrid";
            this.expectedGrid.ReadOnly = true;
            this.expectedGrid.Size = new System.Drawing.Size(577, 143);
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
            this.label2.Location = new System.Drawing.Point(56, 188);
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
            this.actualGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actualGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeCol,
            this.emotionColAct});
            this.actualGrid.Location = new System.Drawing.Point(14, 214);
            this.actualGrid.Margin = new System.Windows.Forms.Padding(5);
            this.actualGrid.Name = "actualGrid";
            this.actualGrid.ReadOnly = true;
            this.actualGrid.Size = new System.Drawing.Size(577, 244);
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
            // ExpectedActualResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expectedGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ExpectedActualResult";
            this.Text = "ExpectedActualResult";
            ((System.ComponentModel.ISupportInitialize)(this.expectedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualGrid)).EndInit();
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
    }
}