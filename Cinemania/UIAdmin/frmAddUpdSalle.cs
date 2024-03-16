using Models;
using Newtonsoft.Json;
using System.Text;
using static UIAdmin.frmAddUpdSalle;

namespace UIAdmin
{
    public partial class frmAddUpdSalle : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        private readonly int _cinemaId;

        public enum Mode { Ajout, Modification }
        private Mode _modeActuel;
        private SalleDTO _salleSelectionnee;
        public frmAddUpdSalle(int cinemaId, Mode mode, SalleDTO? salle = null)
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
            Utils.InitialiserNumSalle(cmbNumSalle);
            Utils.InitialiserQteRangees(cmbQteRangees);
            Utils.InitialiserQtePlaces(cmbNbrPlace);
        }

        private void PreremplirChamps(SalleDTO salle)
        {
            cmbNumSalle.SelectedItem = Convert.ToInt32(salle.sa_numeroSalle);
            cmbQteRangees.SelectedItem = Convert.ToInt32(salle.sa_qteRangees);
            cmbNbrPlace.SelectedItem = Convert.ToInt32(salle.sa_qtePlace);
            MettreAJourPlacesParRangee();
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
            var response = await client.PutAsync("https://localhost:7013/Admin/Salles/MajSalle/" + salle.sa_id, content);
            return response.IsSuccessStatusCode;
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void cmbNumSalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int salleSelectionnee = Convert.ToInt32(cmbNumSalle.SelectedItem);

            // Passer l'ID de la salle actuelle en mode Modification, sinon null en mode Ajout
            int? salleIdExclue = _modeActuel == Mode.Modification ? _salleSelectionnee?.sa_id : null;
            bool estUtilise = await NumeroSalleUtilise(_cinemaId, salleSelectionnee, salleIdExclue);

            lblAvertissement.Text = estUtilise ? "Numéro de salle déjà utilisé pour ce cinéma." : "";
        }
        private async Task<bool> NumeroSalleUtilise(int cinemaId, int numeroSalle, int? salleIdExclue = null)
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/SallesByCinema/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var salles = JsonConvert.DeserializeObject<List<SalleDTO>>(responseString);

                    // Vérifie si une des salles, autre que 'salleIdExclue', utilise le numéro de salle spécifié
                    return salles.Any(salle => salle.sa_numeroSalle == numeroSalle && salle.sa_id != salleIdExclue);
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
