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
    public partial class Language : Form
    {
        bool EN;
        bool NL;


        public Language()
        {
            InitializeComponent();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            NL = false;
            EN  = true;
        }

        private void dutchButton_Click(object sender, EventArgs e)
        {
            EN = false;
            NL = true;
        }

        private void Language_Load(object sender, EventArgs e)
        {
            EN = Properties.Settings.Default.EN;
            NL = Properties.Settings.Default.NL;
        }

        private void Language_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.EN = EN;
            Properties.Settings.Default.NL = NL;
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.EN = EN;
            Properties.Settings.Default.NL = NL;

            if (EN)
            {
                englishButton.Text = "English";
                dutchButton.Text = "Dutch";
                gobackButton.Text = "Go Back";
                
            }

            if (NL)
            {
                englishButton.Text = "Engels;";
                dutchButton.Text = "Nederlands";
                gobackButton.Text = "Ga Terug";
            }
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EN = EN;
            Properties.Settings.Default.NL = NL;

            Properties.Settings.Default.Save();

            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void closeImage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EN = EN;
            Properties.Settings.Default.NL = NL;

            Properties.Settings.Default.Save();

            this.Close();

        }
    }
}
