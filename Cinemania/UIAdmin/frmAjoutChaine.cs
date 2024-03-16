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

            bool isSuccess = await AjouterChaine(chaine);

            if (isSuccess)
            {
                MessageBox.Show("Chaine de cinéma ajoutée avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("L'ajout de la chaine a échoué.");
            }
        }
        private async Task<bool> AjouterChaine(ChaineCinemaEtSalleDTO chaine)
        {
            var content = new StringContent(JsonConvert.SerializeObject(chaine), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/Chaine/AjouterChaine", content);
            return response.IsSuccessStatusCode;
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
