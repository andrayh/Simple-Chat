using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tester
{

    public partial class Login : Form
    {

        bool EN;
        bool NL;

        public Login()
        {
            InitializeComponent();
        }

        string password;
        private Point location;
        bool appmove = false;

        private void UsernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))

            {
                e.Cancel = true;
                UsernameTextBox.Focus();
                errorProvider1.SetError(UsernameTextBox, "Please enter your username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UsernameTextBox, null);
                
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordLabel.Visible = false;

           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            password = PasswordTextBox.Text;

            if (PasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter your password");
            }
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                
                UsernameTextBox.Clear();
            }
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                
                PasswordTextBox.Clear();
            }
            else if(ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Hide();
                Application app = new Application(UsernameTextBox.Text);
                app.ShowDialog();
            }

           

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sn = new SignUp();
            sn.ShowDialog();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameLabel.Visible = false;
        }

        private void closeImage_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Focus();
        }

        #region MouseMovement 
        private void loginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (appmove)
            {
                this.Left = e.X + this.Left - (location.X);
                this.Top = e.Y + this.Top - (location.Y);
            }
        }



        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            appmove = true;
            this.Cursor = Cursors.SizeAll; 
            location = e.Location; 
        }

        private void loginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            appmove = false; 
            this.Cursor = Cursors.Default;         
        }


        #endregion

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Focus();
        }

        bool passwordvisibility;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!passwordvisibility)
            {
                passwordvisibility = true;
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordvisibility = false;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            EN = Properties.Settings.Default.EN;
            NL = Properties.Settings.Default.NL;

            Console.WriteLine("NL: " +  Properties.Settings.Default.NL);
            Console.WriteLine("EN: " +  Properties.Settings.Default.EN);
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            if (EN)
            {
                loginLabel.Text = "Login";
                UsernameLabel.Text = "Username";
                PasswordLabel.Text = "Password";
                SignInButton.Text = "Sign Up";
                LoginButton.Text = "Login";
            }

            if (NL)
            {
                loginLabel.Text = "Aanmelden";
                UsernameLabel.Text = "Gebruikersnaam";
                PasswordLabel.Text = "Wachtwoord";
                SignInButton.Text = "Registeren";
                LoginButton.Text = "Aanmelden";
            }
        }
    }
}
