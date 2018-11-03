namespace SplitVideo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.intoFramesButton = new System.Windows.Forms.Button();
            this.metaDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(863, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear Video";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(523, 20);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(323, 20);
            this.filePath.TabIndex = 4;
            // 
            // intoFramesButton
            // 
            this.intoFramesButton.Location = new System.Drawing.Point(863, 180);
            this.intoFramesButton.Name = "intoFramesButton";
            this.intoFramesButton.Size = new System.Drawing.Size(75, 23);
            this.intoFramesButton.TabIndex = 5;
            this.intoFramesButton.Text = "Cut";
            this.intoFramesButton.UseVisualStyleBackColor = true;
            this.intoFramesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // metaDataRichTextBox
            // 
            this.metaDataRichTextBox.Location = new System.Drawing.Point(523, 325);
            this.metaDataRichTextBox.Name = "metaDataRichTextBox";
            this.metaDataRichTextBox.Size = new System.Drawing.Size(184, 95);
            this.metaDataRichTextBox.TabIndex = 7;
            this.metaDataRichTextBox.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(523, 46);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(323, 241);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // mdLabel
            // 
            this.mdLabel.AutoSize = true;
            this.mdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdLabel.Location = new System.Drawing.Point(519, 302);
            this.mdLabel.Name = "mdLabel";
            this.mdLabel.Size = new System.Drawing.Size(144, 20);
            this.mdLabel.TabIndex = 8;
            this.mdLabel.Text = "Video Meta Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 618);
            this.Controls.Add(this.mdLabel);
            this.Controls.Add(this.metaDataRichTextBox);
            this.Controls.Add(this.intoFramesButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button intoFramesButton;
        private System.Windows.Forms.RichTextBox metaDataRichTextBox;
        private System.Windows.Forms.Label mdLabel;
    }
}

