namespace SplitVideo.Test
{
    partial class FormMain
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.PanelParams = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBoxCaptions = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBoxTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelSex = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelGlasses = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelSmile = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelSurprise = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelSadness = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelNeutral = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelHappiness = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelFear = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelDisgust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelContempt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelAnger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelDominated = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.PanelParams.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(450, 450);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(468, 12);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(118, 37);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Открыть...";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // PanelParams
            // 
            this.PanelParams.Controls.Add(this.groupBox3);
            this.PanelParams.Controls.Add(this.groupBox2);
            this.PanelParams.Controls.Add(this.groupBox1);
            this.PanelParams.Location = new System.Drawing.Point(468, 55);
            this.PanelParams.Name = "PanelParams";
            this.PanelParams.Size = new System.Drawing.Size(412, 406);
            this.PanelParams.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBoxCaptions);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TBoxTags);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(216, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 400);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computer Vision API";
            // 
            // TBoxCaptions
            // 
            this.TBoxCaptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxCaptions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxCaptions.Location = new System.Drawing.Point(6, 299);
            this.TBoxCaptions.Multiline = true;
            this.TBoxCaptions.Name = "TBoxCaptions";
            this.TBoxCaptions.ReadOnly = true;
            this.TBoxCaptions.Size = new System.Drawing.Size(179, 84);
            this.TBoxCaptions.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "ОПИСАНИЯ";
            // 
            // TBoxTags
            // 
            this.TBoxTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBoxTags.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxTags.Location = new System.Drawing.Point(6, 53);
            this.TBoxTags.Multiline = true;
            this.TBoxTags.Name = "TBoxTags";
            this.TBoxTags.ReadOnly = true;
            this.TBoxTags.Size = new System.Drawing.Size(179, 204);
            this.TBoxTags.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "ТЕГИ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelSex);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.LabelGlasses);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LabelSmile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прочие данные";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSex.Location = new System.Drawing.Point(76, 81);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(15, 20);
            this.LabelSex.TabIndex = 23;
            this.LabelSex.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Пол:";
            // 
            // LabelGlasses
            // 
            this.LabelGlasses.AutoSize = true;
            this.LabelGlasses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGlasses.Location = new System.Drawing.Point(76, 49);
            this.LabelGlasses.Name = "LabelGlasses";
            this.LabelGlasses.Size = new System.Drawing.Size(15, 20);
            this.LabelGlasses.TabIndex = 21;
            this.LabelGlasses.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Очки: ";
            // 
            // LabelSmile
            // 
            this.LabelSmile.AutoSize = true;
            this.LabelSmile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSmile.Location = new System.Drawing.Point(101, 29);
            this.LabelSmile.Name = "LabelSmile";
            this.LabelSmile.Size = new System.Drawing.Size(15, 20);
            this.LabelSmile.TabIndex = 19;
            this.LabelSmile.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Улыбка:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelSurprise);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LabelSadness);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LabelNeutral);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LabelHappiness);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LabelFear);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LabelDisgust);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LabelContempt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LabelAnger);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelDominated);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Эмоции";
            // 
            // LabelSurprise
            // 
            this.LabelSurprise.AutoSize = true;
            this.LabelSurprise.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSurprise.Location = new System.Drawing.Point(104, 191);
            this.LabelSurprise.Name = "LabelSurprise";
            this.LabelSurprise.Size = new System.Drawing.Size(14, 15);
            this.LabelSurprise.TabIndex = 17;
            this.LabelSurprise.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Удивление:";
            // 
            // LabelSadness
            // 
            this.LabelSadness.AutoSize = true;
            this.LabelSadness.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSadness.Location = new System.Drawing.Point(104, 174);
            this.LabelSadness.Name = "LabelSadness";
            this.LabelSadness.Size = new System.Drawing.Size(14, 15);
            this.LabelSadness.TabIndex = 15;
            this.LabelSadness.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Печаль:";
            // 
            // LabelNeutral
            // 
            this.LabelNeutral.AutoSize = true;
            this.LabelNeutral.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNeutral.Location = new System.Drawing.Point(104, 157);
            this.LabelNeutral.Name = "LabelNeutral";
            this.LabelNeutral.Size = new System.Drawing.Size(14, 15);
            this.LabelNeutral.TabIndex = 13;
            this.LabelNeutral.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Нейтральный:";
            // 
            // LabelHappiness
            // 
            this.LabelHappiness.AutoSize = true;
            this.LabelHappiness.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHappiness.Location = new System.Drawing.Point(104, 140);
            this.LabelHappiness.Name = "LabelHappiness";
            this.LabelHappiness.Size = new System.Drawing.Size(14, 15);
            this.LabelHappiness.TabIndex = 11;
            this.LabelHappiness.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Счастье:";
            // 
            // LabelFear
            // 
            this.LabelFear.AutoSize = true;
            this.LabelFear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFear.Location = new System.Drawing.Point(104, 123);
            this.LabelFear.Name = "LabelFear";
            this.LabelFear.Size = new System.Drawing.Size(14, 15);
            this.LabelFear.TabIndex = 9;
            this.LabelFear.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Страх:";
            // 
            // LabelDisgust
            // 
            this.LabelDisgust.AutoSize = true;
            this.LabelDisgust.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisgust.Location = new System.Drawing.Point(104, 106);
            this.LabelDisgust.Name = "LabelDisgust";
            this.LabelDisgust.Size = new System.Drawing.Size(14, 15);
            this.LabelDisgust.TabIndex = 7;
            this.LabelDisgust.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Отвращение:";
            // 
            // LabelContempt
            // 
            this.LabelContempt.AutoSize = true;
            this.LabelContempt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContempt.Location = new System.Drawing.Point(104, 89);
            this.LabelContempt.Name = "LabelContempt";
            this.LabelContempt.Size = new System.Drawing.Size(14, 15);
            this.LabelContempt.TabIndex = 5;
            this.LabelContempt.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Презрение:";
            // 
            // LabelAnger
            // 
            this.LabelAnger.AutoSize = true;
            this.LabelAnger.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnger.Location = new System.Drawing.Point(104, 72);
            this.LabelAnger.Name = "LabelAnger";
            this.LabelAnger.Size = new System.Drawing.Size(14, 15);
            this.LabelAnger.TabIndex = 3;
            this.LabelAnger.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Гнев:";
            // 
            // LabelDominated
            // 
            this.LabelDominated.AutoSize = true;
            this.LabelDominated.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDominated.Location = new System.Drawing.Point(11, 32);
            this.LabelDominated.Name = "LabelDominated";
            this.LabelDominated.Size = new System.Drawing.Size(16, 21);
            this.LabelDominated.TabIndex = 0;
            this.LabelDominated.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(22, 17);
            this.StatusLabel.Text = "Ок";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PanelParams);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.Picture);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Распознать и анализировать";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.PanelParams.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Panel PanelParams;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBoxCaptions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBoxTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelGlasses;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelSmile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelSurprise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelSadness;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelNeutral;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelHappiness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelFear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelDisgust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelContempt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelAnger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelDominated;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

