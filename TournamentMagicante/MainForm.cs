using System;
using System.Collections.Generic;
using Vista;
using System.Windows.Forms;

namespace TournamentMagicante
{
    public partial class MainForm : Form
    {
        private int m_codPlayer;

        public MainForm(int codPlayer, string username)
        {
            InitializeComponent();
            m_codPlayer = codPlayer;

            List<string> formatsSource = Utils.ObtainTournamentFormats();
            comboBox1.DataSource = formatsSource;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Text = "Panel Usuario @" + username + " - Magicante";
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseLocation f = new ChooseLocation();
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
                textBox1.Text = f.LocationSelected;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil f = new Perfil(m_codPlayer);
            f.ShowDialog();
        }
    }
}
