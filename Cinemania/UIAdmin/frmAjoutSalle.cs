using Models;
using Newtonsoft.Json;
using System.Text;

namespace UIAdmin
{
    public partial class frmAjoutSalle : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        private readonly int _cinemaId;
        public frmAjoutSalle(int cinemaId)
        {
            InitializeComponent();
            InitialiserComboBoxes();
            _cinemaId = cinemaId;
        }

        private void InitialiserComboBoxes()
        {
            //Numero de salle
            for (int i = 2; i <= 20; i++)
            {
                cmbNumSalle.Items.Add(i);
            }
            //Quantité de rangées
            for (int i = 1; i <= 5; i++)
            {
                cmbQteRangees.Items.Add(i);
            }
            //Quantité de places
            for (int i = 5; i <= 50; i++)
            {
                cmbNbrPlace.Items.Add(i);
            }
        }

        public void CalculerPlacesParRangee()
        {
            if (cmbNbrPlace.SelectedItem != null && cmbQteRangees.SelectedItem != null)
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
            if (cmbNumSalle.SelectedItem == null || cmbQteRangees.SelectedItem == null || cmbNbrPlace.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner des valeurs pour tous les champs.");
                return;
            }

            // Le total des places doit être divisible par le nombre de rangées
            if (_qtePlacesRangee <= 0)
            {
                MessageBox.Show("Le nombre de places par rangée n'est pas juste");
                return;
            }
            var salleDTO = new AjoutSalleDTO
            {
                sa_numeroSalle = (int)cmbNumSalle.SelectedItem,
                sa_qteRangees = (int)cmbQteRangees.SelectedItem,
                sa_qtePlace = (int)cmbNbrPlace.SelectedItem,
                sa_qtePlace_Rangee = _qtePlacesRangee,
                sa_ci_id = _cinemaId
            };

            bool isSuccess = await AjouterSalle(salleDTO);

            if (isSuccess)
            {
                MessageBox.Show("Salle de cinéma ajouté avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("L'ajout de la salle de cinéma a échoué.");
            }
        }

        private async Task<bool> AjouterSalle(AjoutSalleDTO Salle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Salle), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/Salles/AjoutSalle", content);
            return response.IsSuccessStatusCode;
        }

        private void cmbNbrPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculerPlacesParRangee();
        }

        private void cmbQteRangees_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculerPlacesParRangee();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void cmbNumSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int salleSelectionnee = Convert.ToInt32(cmbNumSalle.SelectedItem);
            bool estUtilise = await NumeroSalleUtiliseAsync(_cinemaId, salleSelectionnee);

            if (estUtilise)
            {
                lblAvertissement.Text = "Numéro de salle déjà utilisé pour ce cinéma.";
            }
            else
            {
                lblAvertissement.Text = ""; // Effacer l'avertissement si le numéro n'est pas utilisé
            }
        }
        private async Task<bool> NumeroSalleUtiliseAsync(int cinemaId, int numeroSalle)
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/SallesByCinema/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var salles = JsonConvert.DeserializeObject<List<SalleDTO>>(responseString);

                    // Vérifie si une des salles utilise le numéro de salle spécifié
                    return salles.Any(salle => salle.sa_numeroSalle == numeroSalle);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de vérification de l'utilisation du numéro de salle " + ex.Message);
                return false;
            }
        }
    }
}
