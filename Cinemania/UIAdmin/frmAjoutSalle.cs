using Models;
using Newtonsoft.Json;
using System.Text;
using static UIAdmin.frmAjoutSalle;

namespace UIAdmin
{
    public partial class frmAjoutSalle : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        private readonly int _cinemaId;

        public enum Mode { Ajout, Modification }
        private Mode _modeActuel;
        private SalleDTO _salleSelectionnee;
        public frmAjoutSalle(int cinemaId, Mode mode, SalleDTO salle = null)
        {
            InitializeComponent();
            InitialiserComboBoxes();
            _cinemaId = cinemaId;
            _modeActuel = mode;
            _salleSelectionnee = salle;

            if (_modeActuel == Mode.Modification && _salleSelectionnee != null)
            {
                PreremplirChamps(_salleSelectionnee);
            }
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

        private void PreremplirChamps(SalleDTO salle)
        {
            cmbNumSalle.SelectedItem = salle.sa_numeroSalle.ToString();
            cmbQteRangees.SelectedItem = salle.sa_qteRangees.ToString();
            cmbNbrPlace.SelectedItem = salle.sa_qtePlace.ToString();
            CalculerPlacesParRangee();
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

            if (_qtePlacesRangee <= 0)
            {
                MessageBox.Show("Le nombre de places par rangée n'est pas juste.");
                return;
            }

            bool isSuccess;

            if (_modeActuel == Mode.Ajout)
            {
                var salleDTO = new AjoutSalleDTO
                {
                    sa_numeroSalle = Convert.ToInt32(cmbNumSalle.SelectedItem),
                    sa_qteRangees = Convert.ToInt32(cmbQteRangees.SelectedItem),
                    sa_qtePlace = Convert.ToInt32(cmbNbrPlace.SelectedItem),
                    sa_qtePlace_Rangee = _qtePlacesRangee,
                    sa_ci_id = _cinemaId
                };

                isSuccess = await AjouterSalle(salleDTO);
            }
            else // Mode.Modification
            {
                var salleDTO = new MajSalleDTO
                {
                    sa_id = _salleSelectionnee.sa_id,
                    sa_numeroSalle = Convert.ToInt32(cmbNumSalle.SelectedItem),
                    sa_qteRangees = Convert.ToInt32(cmbQteRangees.SelectedItem),
                    sa_qtePlace = Convert.ToInt32(cmbNbrPlace.SelectedItem),
                    sa_qtePlace_Rangee = _qtePlacesRangee,
                    sa_ci_id = _cinemaId
                };

                isSuccess = await ModifierSalle(salleDTO);
            }

            if (isSuccess)
            {
                MessageBox.Show(_modeActuel == Mode.Ajout ? "Salle de cinéma ajoutée avec succès." : "Salle de cinéma modifiée avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(_modeActuel == Mode.Ajout ? "L'ajout de la salle de cinéma a échoué." : "La modification de la salle de cinéma a échoué.");
            }
        }


        private async Task<bool> AjouterSalle(AjoutSalleDTO Salle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Salle), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/Salles/AjoutSalle", content);
            return response.IsSuccessStatusCode;
        }

        private async Task<bool> ModifierSalle(MajSalleDTO salle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(salle), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7013/Admin/Salles/MajSalle/{salle.sa_id}", content);
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
