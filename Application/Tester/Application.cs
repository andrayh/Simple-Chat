using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Application : Form
    {


        string username;
        string message;

        bool EN;
        bool NL;

        public Application(string usernamevalue)
        {
            
            InitializeComponent();
            usernamePanelText.Text = usernamevalue;
            username = usernamevalue;

            ConsoleMessages console = new ConsoleMessages();
            console.welcomemessage = username + " joined the chat";
            string welcomemessage = console.welcomemessage;

            Output.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
            Output.AppendText(welcomemessage + '\n');

            ConnectedUsers.Items.Add(username);


        }

        public class ConsoleMessages
        {
            public int warnings = 0;

            public string welcomemessage;
            public string warning;
            public string announcement;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void changeUsernameColor_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Visible = true;
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            message = Input.Text;
            string test = "Commands do not work yet!";
            string help = "Commands do not work yet!";
            
            // this makes sure u cant send messages when its empty
            if (string.IsNullOrEmpty(message)) { }
            else if (string.IsNullOrWhiteSpace(message))
            {
                Input.Clear();
            }
            //
            else
            {
                //this adds text to the richtextbox
                Output.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
                Output.AppendText(username + ": " + message + '\n');
                Input.Clear();
            }
           

            
            

            //console

            if (message.Contains("test"))
            {
                Output.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
                Output.SelectionColor = Color.Red;
                Output.AppendText("[Console] " + test + '\n');
            }

            if (message.Contains("/help"))
            {
                Output.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
                Output.SelectionColor = Color.Red;
                Output.AppendText("[Console] " + help + '\n');
            }
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            Output.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
            Output.ScrollToCaret();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void usernamePanelText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernamePanelText.Text))
            {
                MessageBox.Show("Unknown Error" + MessageBoxButtons.OK);
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EN = EN;
            Properties.Settings.Default.NL = NL;
            Environment.Exit(0);
        }


        private Point location;
        bool appmove = false;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            appmove = false;
            this.Cursor = Cursors.Default;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            appmove = true;
            this.Cursor = Cursors.SizeAll;
            location = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (appmove)
            {
                this.Left = e.X + this.Left - (location.X);
                this.Top = e.Y + this.Top - (location.Y);
            }
        }

        private void helpLabel_Click(object sender, EventArgs e)
        {
            Input.Focus();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Input.Text))
            {
                Input.Clear();
            }
        }


        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            message = Input.Text;
            string help = "Click on the brush to change text color.";

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(message)) { }
                else if (string.IsNullOrWhiteSpace(message))
                {
                    Input.Clear();
                }

                else
                {
                    Output.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
                    Output.AppendText(username + ": ");
                    Output.SelectionColor = Input.ForeColor;
                    Output.AppendText(message + '\n');
                    Input.Clear();
                }

                //console

                if (message.Contains("/help"))
                {
                    Output.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
                    Output.SelectionColor = Color.Red;
                    Output.AppendText("[Console] " + help + '\n');
                }
            }
        }

        #region colorpicker
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            if (colorDialog.Color == Color.White)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.Red)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.DarkGray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.Gray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.LightGray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.DimGray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.LightSlateGray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.SlateGray)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.DarkBlue)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.DarkSlateBlue)
            {
                MessageBox.Show("Color not allowed!");
            }
            else if (colorDialog.Color == Color.Yellow)
            {
                MessageBox.Show("Color not allowed!");
            }
            else
            {
                Input.ForeColor = colorDialog.Color;
            }
        }
        #endregion

        private void checker_Tick(object sender, EventArgs e)
        {
            EN = Properties.Settings.Default.EN;
            NL = Properties.Settings.Default.NL;

            if (EN)
            {
                applicationName.Text = "Beta Chat";
                connectionBox.Text = "Users";
                chatBox.Text = "Chat";
                settingsButton.Text = "Settings";
                sendButton.Text = "Send";
                goBackButton.Text = "Go Back";
                closeButton.Text = "Close";
                panelText.Text = "Logged on as: ";
                notConnectedLabel.Text = "Not Connected;";
            }

            if (NL)
            {
                applicationName.Text = "Beta Chat";
                connectionBox.Text = "Gebruikers";
                chatBox.Text = "Chat";
                settingsButton.Text = "Instellingen";
                sendButton.Text = "Stuur";
                goBackButton.Text = "Ga terug";
                closeButton.Text = "Sluit";
                panelText.Text = "Aangemeld als: ";
                notConnectedLabel.Text = "Niet verbonden";
            }
        }

        private void Application_Load(object sender, EventArgs e)
        {
            EN = Properties.Settings.Default.EN;
            NL = Properties.Settings.Default.NL;
        }

        private void Application_FormClosing(object sender, FormClosingEventArgs e)
        {       
        }
    }
}

