using Microsoft.VisualBasic.Logging;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAdmin
{
    public partial class frmAjoutChaine : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        public frmAjoutChaine()
        {
            InitializeComponent();
            InitialiserComboBoxes();
        }
        private void InitialiserComboBoxes()
        {
            Utils.InitialiserQteRangees(cmbQteRangees);
            Utils.InitialiserQtePlaces(cmbNbrPlace);
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomCinema.Text) || cmbQteRangees.SelectedItem == null || cmbNbrPlace.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs requis");
                return;
            }

            // Le total des places doit être divisible par le nombre de rangées
            if (_qtePlacesRangee <= 0)
            {
                MessageBox.Show("Le nombre de places par rangée n'est pas juste");
                return;
            }
            var chaine = new ChaineCinemaEtSalleDTO
            {
                NomChaine= txtNomChaine.Text,

                NomCinema = txtNomCinema.Text,
                AdresseCinema = txtAdresse.Text,

                // Ici, c'est les valeurs de la salle
                NumeroSalle = 1, // Toujours 1 pour un nouveau cinéma
                QteRangees = (int)cmbQteRangees.SelectedItem,
                QtePlace = (int)cmbNbrPlace.SelectedItem,
                QtePlacesRangee = _qtePlacesRangee
            };

            var errorMessage = await AjouterChaine(chaine);

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Chaine de cinéma ajoutée avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
        private async Task<string> AjouterChaine(ChaineCinemaEtSalleDTO chaine)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(chaine), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7013/Admin/Chaine/AjouterChaine", content);

                if (response.IsSuccessStatusCode)
                {
                    return string.Empty; // Opération réussie
                }
                else
                {
                    // Lire le contenu de la réponse pour obtenir le message d'erreur métier
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var statusCode = response.StatusCode;
                    // Ici, vous pouvez utiliser 'statusCode' pour affiner la gestion des erreurs
                    Console.WriteLine("Échec de la requête : " + statusCode);
                    return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de la requête avec le statut " + statusCode;
                }
            }
            catch (Exception ex)
            {
                // Ce bloc attrape les exceptions qui ne sont pas liées à des réponses HTTP d'erreur
                Console.WriteLine("Une erreur est survenue lors de la communication avec l'API : " + ex.Message);
                return "Une erreur inattendue est survenue.";
            }
        }
        private void MettreAJourPlacesParRangee()
        {
            if (cmbNbrPlace.SelectedItem != null && cmbQteRangees.SelectedItem != null)
            {
                int totalPlaces = Convert.ToInt32(cmbNbrPlace.SelectedItem);
                int totalRangees = Convert.ToInt32(cmbQteRangees.SelectedItem);
                string message;

                _qtePlacesRangee = Utils.CalculerPlacesParRangee(totalPlaces, totalRangees, out message);
                lblPlacesParRangee.Text = message;
            }
        }

        private void cmbQteRangees_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourPlacesParRangee();
        }
        private void cmbNbrPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourPlacesParRangee();
        }
    }
}
