namespace Tester
{
    partial class Application
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
            this.closeButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Label();
            this.usernamePanelText = new System.Windows.Forms.Label();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.notConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectedUsers = new System.Windows.Forms.ListBox();
            this.connectionBox = new System.Windows.Forms.GroupBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.applicationName = new System.Windows.Forms.Label();
            this.closeImage = new System.Windows.Forms.PictureBox();
            this.chatBox = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.PictureBox();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.usernamePanel.SuspendLayout();
            this.connectionBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            this.chatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(953, 648);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.Window;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Output.Location = new System.Drawing.Point(6, 19);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(787, 470);
            this.Output.TabIndex = 3;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(229, 560);
            this.Input.MaxLength = 200;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(703, 20);
            this.Input.TabIndex = 4;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(953, 559);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 22);
            this.sendButton.TabIndex = 5;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(953, 619);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 6;
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panelText
            // 
            this.panelText.ForeColor = System.Drawing.Color.Red;
            this.panelText.Location = new System.Drawing.Point(3, 6);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(77, 23);
            this.panelText.TabIndex = 7;
            // 
            // usernamePanelText
            // 
            this.usernamePanelText.ForeColor = System.Drawing.Color.Red;
            this.usernamePanelText.Location = new System.Drawing.Point(86, 6);
            this.usernamePanelText.Name = "usernamePanelText";
            this.usernamePanelText.Size = new System.Drawing.Size(75, 23);
            this.usernamePanelText.TabIndex = 8;
            this.usernamePanelText.Text = "Unknown";
            this.usernamePanelText.Click += new System.EventHandler(this.usernamePanelText_Click);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamePanel.Controls.Add(this.notConnectedLabel);
            this.usernamePanel.Controls.Add(this.panelText);
            this.usernamePanel.Controls.Add(this.usernamePanelText);
            this.usernamePanel.Location = new System.Drawing.Point(12, 641);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(370, 30);
            this.usernamePanel.TabIndex = 9;
            // 
            // notConnectedLabel
            // 
            this.notConnectedLabel.AutoSize = true;
            this.notConnectedLabel.ForeColor = System.Drawing.Color.Red;
            this.notConnectedLabel.Location = new System.Drawing.Point(276, 6);
            this.notConnectedLabel.Name = "notConnectedLabel";
            this.notConnectedLabel.Size = new System.Drawing.Size(79, 13);
            this.notConnectedLabel.TabIndex = 12;
            this.notConnectedLabel.Text = "Not Connected";
            this.notConnectedLabel.Visible = false;
            // 
            // ConnectedUsers
            // 
            this.ConnectedUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectedUsers.FormattingEnabled = true;
            this.ConnectedUsers.Location = new System.Drawing.Point(5, 19);
            this.ConnectedUsers.Name = "ConnectedUsers";
            this.ConnectedUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ConnectedUsers.Size = new System.Drawing.Size(200, 470);
            this.ConnectedUsers.Sorted = true;
            this.ConnectedUsers.TabIndex = 10;
            // 
            // connectionBox
            // 
            this.connectionBox.Controls.Add(this.ConnectedUsers);
            this.connectionBox.Location = new System.Drawing.Point(12, 51);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(211, 502);
            this.connectionBox.TabIndex = 11;
            this.connectionBox.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 560);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(211, 21);
            this.settingsButton.TabIndex = 13;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.changeUsernameColor_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            this.colorDialog.SolidColorOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.applicationName);
            this.panel1.Controls.Add(this.closeImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 43);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationName.Location = new System.Drawing.Point(7, 9);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(0, 25);
            this.applicationName.TabIndex = 1;
            // 
            // closeImage
            // 
            this.closeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeImage.Image = global::Tester.Properties.Resources.close__1_;
            this.closeImage.Location = new System.Drawing.Point(1003, 9);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(25, 25);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeImage.TabIndex = 0;
            this.closeImage.TabStop = false;
            this.closeImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chatBox
            // 
            this.chatBox.Controls.Add(this.Output);
            this.chatBox.Location = new System.Drawing.Point(229, 51);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(799, 502);
            this.chatBox.TabIndex = 16;
            this.chatBox.TabStop = false;
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.Window;
            this.colorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.Image = global::Tester.Properties.Resources.icons8_paint_brush_30;
            this.colorButton.Location = new System.Drawing.Point(931, 560);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(20, 20);
            this.colorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorButton.TabIndex = 18;
            this.colorButton.TabStop = false;
            this.colorButton.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Interval = 50;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 681);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.connectionBox);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Application";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Application_FormClosing);
            this.Load += new System.EventHandler(this.Application_Load);
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.connectionBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            this.chatBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label panelText;
        private System.Windows.Forms.Label usernamePanelText;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.ListBox ConnectedUsers;
        private System.Windows.Forms.GroupBox connectionBox;
        private System.Windows.Forms.Label notConnectedLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.PictureBox closeImage;
        private System.Windows.Forms.GroupBox chatBox;
        private System.Windows.Forms.PictureBox colorButton;
        private System.Windows.Forms.Timer checker;
    }
}