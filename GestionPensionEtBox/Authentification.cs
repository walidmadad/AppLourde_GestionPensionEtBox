using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPensionEtBox.Controller;
using MySqlX.XDevAPI;
using Newtonsoft.Json;

namespace GestionPensionEtBox
{
    
    public partial class Authentification : Form
    {

        private readonly HttpClient client = new HttpClient();
        private readonly string apiURL = "http://172.20.10.2/api_Logiciel/ConnexionPension.php";

        public Authentification()
        {
            InitializeComponent();
        }

        private async void btn_cnx_Click(object sender, EventArgs e)
        {

            string email = txt_nomPension.Text;
            string mdp = txt_mdp.Text;

            var postData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("password", mdp)
            });

            HttpResponseMessage response = await client.PostAsync(apiURL, postData);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);

                if (jsonResponse.status == "success")
                {
                    this.Hide();
                    Menu.IDPension = jsonResponse.id;
                    Menu frm = new Menu();
                    frm.lbl_nomPension.Text = jsonResponse.nom;
                    frm.ShowDialog();
                }
                else
                {
                    lbl_error.Text = jsonResponse.message;
                    lbl_error.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lbl_error.Text = "Erreur lors de la connexion à l'API";
                lbl_error.ForeColor = System.Drawing.Color.Red;
            }
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}