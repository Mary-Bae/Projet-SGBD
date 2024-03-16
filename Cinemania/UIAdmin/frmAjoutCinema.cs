using Models;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Channels;

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
            Utils.InitialiserQteRangees(cmbQteRangees);
            Utils.InitialiserQtePlaces(cmbNbrPlace);
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
            var errorMessage = await AjouterCinemaEtSalle(cinemaEtSalleDTO);

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Cinéma ajouté avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private async Task<string> AjouterCinemaEtSalle(CinemaEtSalleDTO cinemaEtSalle)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(cinemaEtSalle), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7013/Admin/Cinemas/AjouterCinema", content);

                if (response.IsSuccessStatusCode)
                {
                    return string.Empty; // Opération réussie
                }
                else
                {
                    // Lire le contenu de la réponse pour obtenir le message d'erreur métier
                    var errorContent = await response.Content.ReadAsStringAsync();

                    // Utilisation de 'statusCode' pour affiner la gestion des erreurs
                    var statusCode = response.StatusCode;
                    Console.WriteLine("Échec de la requête : " + statusCode);
                    return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de la requête avec le statut " + statusCode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue lors de la communication avec l'API : " + ex.Message);
                return "Une erreur inattendue est survenue.";
            }


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
        }

        private void cmbQteRangees_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourPlacesParRangee();
        }

        private void cmbNbrPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourPlacesParRangee();
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

    }
}
