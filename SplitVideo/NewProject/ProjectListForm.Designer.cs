namespace SplitVideo.NewProject
{
    partial class ProjectListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectsGrid = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attentionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 57);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(908, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 51);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // projectsGrid
            // 
            this.projectsGrid.AllowUserToAddRows = false;
            this.projectsGrid.AllowUserToDeleteRows = false;
            this.projectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectsGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.titleCol,
            this.descriptionCol,
            this.producerCol,
            this.genderCol,
            this.genreCol,
            this.attentionCol,
            this.detailCol});
            this.projectsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsGrid.EnableHeadersVisualStyles = false;
            this.projectsGrid.Location = new System.Drawing.Point(0, 57);
            this.projectsGrid.Name = "projectsGrid";
            this.projectsGrid.ReadOnly = true;
            this.projectsGrid.RowHeadersVisible = false;
            this.projectsGrid.Size = new System.Drawing.Size(977, 392);
            this.projectsGrid.TabIndex = 3;
            this.projectsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsGrid_CellClick);
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 54;
            // 
            // titleCol
            // 
            this.titleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleCol.FillWeight = 427.5862F;
            this.titleCol.HeaderText = "Title";
            this.titleCol.MinimumWidth = 180;
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            // 
            // descriptionCol
            // 
            this.descriptionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionCol.FillWeight = 34.48276F;
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.MinimumWidth = 150;
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            // 
            // producerCol
            // 
            this.producerCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.producerCol.FillWeight = 34.48276F;
            this.producerCol.HeaderText = "Producer";
            this.producerCol.MinimumWidth = 50;
            this.producerCol.Name = "producerCol";
            this.producerCol.ReadOnly = true;
            this.producerCol.Width = 119;
            // 
            // genderCol
            // 
            this.genderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.genderCol.HeaderText = "Gender";
            this.genderCol.MinimumWidth = 50;
            this.genderCol.Name = "genderCol";
            this.genderCol.ReadOnly = true;
            this.genderCol.Width = 107;
            // 
            // genreCol
            // 
            this.genreCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.genreCol.FillWeight = 34.48276F;
            this.genreCol.HeaderText = "Genre";
            this.genreCol.MinimumWidth = 50;
            this.genreCol.Name = "genreCol";
            this.genreCol.ReadOnly = true;
            this.genreCol.Width = 94;
            // 
            // attentionCol
            // 
            this.attentionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.attentionCol.FillWeight = 34.48276F;
            this.attentionCol.HeaderText = "Attention Rate";
            this.attentionCol.MinimumWidth = 80;
            this.attentionCol.Name = "attentionCol";
            this.attentionCol.ReadOnly = true;
            this.attentionCol.Width = 156;
            // 
            // detailCol
            // 
            this.detailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.detailCol.FillWeight = 34.48276F;
            this.detailCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailCol.HeaderText = "Details";
            this.detailCol.Name = "detailCol";
            this.detailCol.ReadOnly = true;
            this.detailCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detailCol.Text = "Details";
            this.detailCol.UseColumnTextForButtonValue = true;
            this.detailCol.Width = 94;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 449);
            this.Controls.Add(this.projectsGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectsForm";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView projectsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn attentionCol;
        private System.Windows.Forms.DataGridViewButtonColumn detailCol;
    }
}