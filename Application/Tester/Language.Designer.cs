namespace Tester
{
    partial class Language
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
            this.components = new System.ComponentModel.Container();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.englishButton = new System.Windows.Forms.Button();
            this.dutchButton = new System.Windows.Forms.Button();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.gobackButton = new System.Windows.Forms.Button();
            this.closeImage = new System.Windows.Forms.PictureBox();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingsPanel.Controls.Add(this.closeImage);
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Location = new System.Drawing.Point(0, -1);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(351, 46);
            this.settingsPanel.TabIndex = 9;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(9, 8);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(0, 25);
            this.settingsLabel.TabIndex = 0;
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(74, 95);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(200, 50);
            this.englishButton.TabIndex = 10;
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // dutchButton
            // 
            this.dutchButton.Location = new System.Drawing.Point(74, 187);
            this.dutchButton.Name = "dutchButton";
            this.dutchButton.Size = new System.Drawing.Size(200, 50);
            this.dutchButton.TabIndex = 11;
            this.dutchButton.UseVisualStyleBackColor = true;
            this.dutchButton.Click += new System.EventHandler(this.dutchButton_Click);
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Interval = 50;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // gobackButton
            // 
            this.gobackButton.Location = new System.Drawing.Point(13, 317);
            this.gobackButton.Name = "gobackButton";
            this.gobackButton.Size = new System.Drawing.Size(75, 23);
            this.gobackButton.TabIndex = 12;
            this.gobackButton.UseVisualStyleBackColor = true;
            this.gobackButton.Click += new System.EventHandler(this.gobackButton_Click);
            // 
            // closeImage
            // 
            this.closeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeImage.Image = global::Tester.Properties.Resources.close__1_;
            this.closeImage.Location = new System.Drawing.Point(313, 8);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(25, 25);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeImage.TabIndex = 8;
            this.closeImage.TabStop = false;
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 352);
            this.Controls.Add(this.gobackButton);
            this.Controls.Add(this.dutchButton);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Language";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Language_FormClosing);
            this.Load += new System.EventHandler(this.Language_Load);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button dutchButton;
        private System.Windows.Forms.Timer checker;
        private System.Windows.Forms.Button gobackButton;
        private System.Windows.Forms.PictureBox closeImage;
    }
}