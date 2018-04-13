using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Vista;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentMagicante
{
    public partial class Perfil : Form
    {
        private int m_codPlayer;
        
        public Perfil(int codPlayer)
        {
            InitializeComponent();
            m_codPlayer = codPlayer;
            var playerData = Utils.ObtainPlayerdata(m_codPlayer);

            nameTb.Text = playerData["name"];
            usernameTb.Text = playerData["username"];
            locationTb.Text = playerData["location"];
            ageNumeric.Value = Convert.ToInt32(playerData["age"]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chooseLocationBt_Click(object sender, EventArgs e)
        {
            ChooseLocation f = new ChooseLocation();
            SetInfoLbMessage("");
            DialogResult result = f.ShowDialog();
            if(result == DialogResult.OK)
                locationTb.Text = f.LocationSelected;
            
        }

        private void modifyDataBt_Click(object sender, EventArgs e)
        {
            modifyDataBt.Enabled = false;
            if(nameTb.Text.Length != 0 && usernameTb.Text.Length != 0 &&
                    locationTb.Text.Length != 0){
                var playerData = new Dictionary<string, string>();
                playerData.Add("cod", m_codPlayer + "");
                playerData.Add("name", nameTb.Text);
                playerData.Add("username", usernameTb.Text);
                playerData.Add("location", locationTb.Text);
                playerData.Add("age", ageNumeric.Value + "");

                if (Utils.UpdatePlayerData(playerData))
                    SetInfoLbMessage("Datos actualizados con éxito.");
                else
                    SetInfoLbMessage("Error actualizando datos.", true);
            }
            else
                SetInfoLbMessage("Algunos campos estan vacíos.", true);
            
            modifyDataBt.Enabled = true;
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            SetInfoLbMessage("");
        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            SetInfoLbMessage("");
        }

        private void ageNumeric_ValueChanged(object sender, EventArgs e)
        {
            SetInfoLbMessage("");
        }

        private void SetInfoLbMessage(string message, bool isError = false)
        {
            infoLb.ForeColor = isError? Color.Red : Color.Black;
            infoLb.Text = message;
        }

        private void pass1Tb_TextChanged(object sender, EventArgs e)
        {
            UpdateModifyPassBt();
        }

        private void UpdateModifyPassBt()
        {
            if (pass1Tb.Text.Length != 0 && pass2Tb.Text.Length != 0)
                modifyPassBt.Enabled = true;
        }

        private void pass2Tb_TextChanged(object sender, EventArgs e)
        {
            UpdateModifyPassBt();
        }

        private void modifyPassBt_Click(object sender, EventArgs e)
        {
            if (pass1Tb.Text.CompareTo(pass2Tb.Text) != 0)
                SetInfoLbMessage("Las contraseñas no coinciden", true);
            else
            {
                if (Utils.UpdatePlayerPassword(m_codPlayer, pass1Tb.Text))
                    SetInfoLbMessage("Contraseñas actualizadas.");
                else
                    SetInfoLbMessage("Error actualizando contraseñas.", true);
            }
        }
    }
}
