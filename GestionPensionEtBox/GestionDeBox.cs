using GestionPensionEtBox.Controller;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace GestionPensionEtBox
{
    public partial class GestionDeBox : Form
    {
        private string idTypeGardiennage;
        private dynamic jsonResponse;

        private readonly HttpClient client = new HttpClient();
        private readonly string apiURL = "http://172.20.10.2/api_Logiciel/afficherTypeGardiennage.php";
        private readonly string apiURL2 = "http://172.20.10.2/api_Logiciel/afficherPrix.php";
        private readonly string apiURL3 = "http://172.20.10.2/api_Logiciel/ModifierPrixEtSupperficie.php";
        public GestionDeBox()
        {
            InitializeComponent();
            LoadData();
        }

        private async void listBox_TypeGard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string idPension = Menu.IDPension;
            

            // Récupérer l'ID du type de gardiennage sélectionné dans la liste
            string selectedTypeGardiennage = listBox_TypeGard.SelectedItem.ToString();

            // Récupérer l'ID correspondant à partir de votre source de données (jsonResponse)
            foreach (var item in jsonResponse)
            {
                if (item.libelle == selectedTypeGardiennage)
                {
                    idTypeGardiennage = item.id_TypeGardiennage;
                    break;
                }
            }

            var postData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("id_pension", idPension),
        new KeyValuePair<string, string>("id_typeGardiennage", idTypeGardiennage)
    });
            HttpResponseMessage response = await client.PostAsync(apiURL2, postData);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);

                if (jsonResponse.status == "success")
                {
                    // Récupérer le tarif et la superficie depuis la réponse
                    string tarif = jsonResponse.tarif;
                    string superficie = jsonResponse.superficie;

                    // Afficher le tarif et la superficie dans vos contrôles
                    txtBox_tarif.Text = tarif;
                    txtbox_Superficie.Text = superficie;
                }
                else
                {
                    MessageBox.Show("Erreur : " + jsonResponse.message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void modifier_btn_Click(object sender, EventArgs e)
        {
            string idPension = Menu.IDPension;

            string nouveauTarif = txtBox_tarif.Text;
            string nouvelleSuperficie = txtbox_Superficie.Text;

            var postData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("id_pension", idPension),
        new KeyValuePair<string, string>("id_typeGardiennage", idTypeGardiennage),
        new KeyValuePair<string, string>("nouveau_tarif", nouveauTarif),
        new KeyValuePair<string, string>("nouvelle_superficie", nouvelleSuperficie)
    });

            HttpResponseMessage response = await client.PostAsync(apiURL3, postData);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);

                if (jsonResponse.status == "success")
                {
                    MessageBox.Show("Données modifiées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur : " + jsonResponse.message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification des données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiURL);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent); // Affectation de jsonResponse

                    if (jsonResponse != null)
                    {
                        foreach (var item in jsonResponse)
                        {
                            string libelle = item.libelle;
                            idTypeGardiennage = item.id_TypeGardiennage;

                            listBox_TypeGard.Items.Add(libelle); // Ajouter le libellé à votre liste
                        }
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
