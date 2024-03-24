using GestionPensionEtBox.Controller;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;


namespace GestionPensionEtBox
{
    public partial class GestionPension : Form
    {
        private readonly string apiURL = "http://172.20.10.2/api_Logiciel/RecupererDonneesPension.php";
        private readonly HttpClient client = new HttpClient();
        private dynamic jsonResponse;
        public GestionPension()
        {
            InitializeComponent();
            
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                var postData = new FormUrlEncodedContent(new[]
                {
            new KeyValuePair<string, string>("id_pension", Menu.IDPension)
        });
                HttpResponseMessage response = await client.PostAsync(apiURL, postData);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent); // Affectation de jsonResponse

                    if (jsonResponse.status == "success")
                    {
                        this.txtBox_ville.Text = jsonResponse.ville_pension ?? "";
                        this.txtBox_responsable.Text = jsonResponse.responsable_pension ?? "";
                        this.txtBox_adresse.Text = jsonResponse.adresse_pension ?? "";
                        this.txtBox_email.Text = jsonResponse.email_pension ?? "";
                        this.txtBox_tel.Text = jsonResponse.telephone_pension ?? "";
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Réponse JSON vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erreur lors de la récupération des données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
