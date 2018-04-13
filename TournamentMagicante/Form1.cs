using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using Vista;

namespace TournamentMagicante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginBt();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginBt();
        }

        private void UpdateLoginBt()
        {
            LogInBt.Enabled = textBox1.Text.Length != 0 && textBox2.Text.Length != 0;

        }

        private void LogInBt_Click(object sender, EventArgs e)
        {
            ProcessLogin();

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (LogInBt.Enabled)
                    ProcessLogin();
            }
        }

        private void ProcessLogin()
        {
            LogInBt.Enabled = false;

            if (Utils.ValidateLogin(textBox1.Text, textBox2.Text))
            {
                int codPlayer = Utils.ObtainPlayerCode(textBox1.Text);
                MainForm f = new MainForm(codPlayer, textBox1.Text);
                f.Show();
                this.Hide();
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Credenciales incorrectos...";
            }
            
            LogInBt.Enabled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (LogInBt.Enabled)
                    ProcessLogin();
            }
        }
    }
}
