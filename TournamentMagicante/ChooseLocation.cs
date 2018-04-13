using System;
using Vista;
using System.Windows.Forms;
using System.Drawing;

namespace TournamentMagicante
{
    public partial class ChooseLocation : Form
    {
        public string LocationSelected { get; set; }
        public ChooseLocation()
        {
            InitializeComponent();
            UpdateLocations();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            LocationSelected = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationSelected = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            textBox1.Text = "";
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0;
            if(label2.Text.Length != 0)
                label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (Utils.InsertNewLocation(textBox1.Text))
            {
                UpdateLocations();
                textBox1.Text = "";
                label2.Text = "Ubicación insertada con éxito";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Error al insertar localización...";
            }
            button1.Enabled = true;
        }

        private void UpdateLocations()
        {
            var locations = Utils.ObtainLocations();
            comboBox1.DataSource = locations;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
