using Models;
using Newtonsoft.Json;
using System.Text;

namespace UIAdmin
{
    public partial class frmAjoutCinema : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        public int ChaineId { get; set; }
        public frmAjoutCinema()
        {
            InitializeComponent();
            InitialiserComboBoxes();
        }

        private void InitialiserComboBoxes()
        {
            //Quantité de rangées
            for(int i = 1; i <= 5; i++)
            {
                cmbQteRangees.Items.Add(i);
            }

            //Quantité de places
            for(int i = 5; i <= 50; i++)
            {
                cmbNbrPlace.Items.Add(i);
            }
        }
        private void CalculerPlacesParRangee()
        {
            if (cmbNbrPlace.SelectedItem != null && cmbQteRangees.SelectedItem != null ) 
            {
                int totalPlaces = Convert.ToInt32(cmbNbrPlace.SelectedItem);
                int totalRangees = Convert.ToInt32(cmbQteRangees.SelectedItem);

                // Verifier si le total des places est divisible par le nombre de rangées sans reste
                if (totalPlaces % totalRangees == 0)
                {
                    _qtePlacesRangee = totalPlaces / totalRangees;
                    lblPlacesParRangee.Text = _qtePlacesRangee + " places par rangée";
                }
                else
                {
                    lblPlacesParRangee.Text = "Erreur : Le total des places doit être divisible par le nombre de rangées";
                    _qtePlacesRangee = 0;
                }
            }
        }
        private async void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomCinema.Text) || cmbQteRangees.SelectedItem == null || cmbNbrPlace.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs requis");
                return;
            }

            // Le total des places doit être divisible par le nombre de rangées
            if(_qtePlacesRangee <= 0)
            {
                MessageBox.Show("Le nombre de places par rangée n'est pas juste");
                return;
            }
            var cinemaEtSalleDTO = new CinemaEtSalleDTO
            {
                NomCinema = txtNomCinema.Text,
                AdresseCinema = txtAdresseCinema.Text,
                CineChaineId = this.ChaineId,

                // Ici, c'est les valeurs de la salle
                NumeroSalle = 1, // Toujours 1 pour un nouveau cinéma
                QteRangees = (int)cmbQteRangees.SelectedItem,
                QtePlace = (int)cmbNbrPlace.SelectedItem,
                QtePlacesRangee = _qtePlacesRangee
            };

            bool isSuccess = await AjouterCinemaEtSalle(cinemaEtSalleDTO);

            if (isSuccess)
            {
                MessageBox.Show("Cinéma et salle ajoutés avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("L'ajout du cinéma et de la salle a échoué.");
            }
        }

        private async Task<bool> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(cinemaEtSalle), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/AjouterCinemaEtSalle", content);
            return response.IsSuccessStatusCode;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
        }

        private void cmbQteRangees_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculerPlacesParRangee();
        }

        private void cmbNbrPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculerPlacesParRangee();
        }
    }
}
