using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIClient
{
    public partial class frmAbonnement : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _selectedChaineId;
        public frmAbonnement()
        {
            InitializeComponent();
            LoadChaine();
            btAcheter.Enabled = false;
        }
        private async void LoadChaine()
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Client/Chaine");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var chaines = JsonConvert.DeserializeObject<BindingList<ChaineDTO>>(responseContent);
                lstChaine.DisplayMember = "ch_nom";
                lstChaine.ValueMember = "ch_id";
                lstChaine.DataSource = chaines;
            }
        }
        private async void btAcheter_Click(object sender, EventArgs e)
        {
            if (lstChaine.SelectedItem is ChaineDTO selectedChaine)
            {
                var abonnementInfo = await AcheterAbonnement(selectedChaine);

                if (abonnementInfo != null)
                {
                    lblMerci.Text = "Nous vous remercions pour votre achat";
                    lblUid.Text = $"UID: {abonnementInfo.Uid}";
                    lblDateAchat.Text = $"Date d'Achat: {abonnementInfo.DateAchat.ToShortDateString()}";
                    lblDateValidite.Text = $"Date de Validité: {abonnementInfo.DateFinValidite.ToShortDateString()}";
                    lblReservationRestante.Text = "Vous avez droit à 6 réservations pour cette chaine de cinéma à partir de ce jour";
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création de l'abonnement.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chaîne.");
            }
        }
        private async Task<AbonnementInfosDTO> AcheterAbonnement(ChaineDTO chaineDto)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(new { ch_id = chaineDto.ch_id });
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Envoi de la requête POST à l'API
                var response = await client.PostAsync("https://localhost:7013/Client/Abonnement/AddAbonnement", content);

                if (response.IsSuccessStatusCode)
                {
                    var abonnementInfo = await response.Content.ReadAsAsync<AbonnementInfosDTO>();
                    return abonnementInfo;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(errorContent);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
                return null;
            }
        }
        private void lstChaine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChaine.SelectedItem is ChaineDTO selectedChaine)
            {
                _selectedChaineId = selectedChaine.ch_id;
                AfficherCinemas(selectedChaine.ch_id);
                btAcheter.Enabled = false;
                lblPayement.Text = "";
            }
            else
            {
                _selectedChaineId = -1;
                lblCine.Text = "";
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter la fenêtre d'abonnement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        private void btChoix_Click(object sender, EventArgs e)
        {
            lblPayement.Text = "Informations de payement :\nPrix de la réservation :  50€\nIBAN : BE65 2343 4433 9110";
            btAcheter.Enabled = true;
        }

        private async void AfficherCinemas(int chaineId)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Client/CinemasByChaine/" + chaineId);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);

                lblCine.Text = "Cinémas auxquels vous aurez droit en vous abonnant à cette chaine:\n\n" + string.Join("\n", cinemas.Select(cinema => cinema.ci_nom));
            }
            else
            {
                lblCine.Text = "";
            }
        }
    }
}
