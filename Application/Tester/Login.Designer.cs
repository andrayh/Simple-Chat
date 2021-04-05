namespace Tester
{
    partial class Login
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.closeImage = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordVisiblity = new System.Windows.Forms.PictureBox();
            this.checker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisiblity)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(290, 149);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(83, 22);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(91, 64);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(207, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.UsernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameTextBox_Validating);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(91, 101);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(207, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameLabel.Location = new System.Drawing.Point(95, 67);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordLabel.Location = new System.Drawing.Point(95, 104);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(12, 149);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(83, 22);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginPanel.Controls.Add(this.closeImage);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Location = new System.Drawing.Point(-1, -2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(387, 42);
            this.loginPanel.TabIndex = 7;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.loginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
            // 
            // closeImage
            // 
            this.closeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeImage.Image = global::Tester.Properties.Resources.close__1_;
            this.closeImage.Location = new System.Drawing.Point(359, 8);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(25, 25);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeImage.TabIndex = 8;
            this.closeImage.TabStop = false;
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(9, 8);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 25);
            this.loginLabel.TabIndex = 0;
            // 
            // passwordVisiblity
            // 
            this.passwordVisiblity.Image = global::Tester.Properties.Resources.icons8_eye_32;
            this.passwordVisiblity.Location = new System.Drawing.Point(304, 101);
            this.passwordVisiblity.Name = "passwordVisiblity";
            this.passwordVisiblity.Size = new System.Drawing.Size(22, 20);
            this.passwordVisiblity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordVisiblity.TabIndex = 8;
            this.passwordVisiblity.TabStop = false;
            this.passwordVisiblity.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Interval = 50;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 183);
            this.Controls.Add(this.passwordVisiblity);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisiblity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox closeImage;
        private System.Windows.Forms.PictureBox passwordVisiblity;
        private System.Windows.Forms.Timer checker;
    }
}

