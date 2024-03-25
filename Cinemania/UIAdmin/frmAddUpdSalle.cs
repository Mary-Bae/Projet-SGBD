using Models;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using static UIAdmin.frmAddUpdSalle;


namespace UIAdmin
{
    
    public partial class frmAddUpdSalle : Form
    {
        public enum Mode { Ajout, Modification }

        private static readonly HttpClient client = new HttpClient();
        private int _qtePlacesRangee = 0;
        private readonly int _cinemaId;

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
            lblAvertissement.Text = "";
            if (cmbQteRangees.SelectedItem == null || cmbNbrPlace.SelectedItem == null || cmbNumSalle.SelectedItem == null)
            {
                lblAvertissement.Text = "Tout doit être sélectionné pour valider l'entrée.";
                return;
            }

            string resultMessage;
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

                resultMessage = await AjouterSalle(salleDTO);
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

                resultMessage = await ModifierSalle(salleDTO);
            }

            if (string.IsNullOrEmpty(resultMessage))
            {
                MessageBox.Show("L'opération a été réalisée avec succès ! Les informations ont été mises à jour dans la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblAvertissement.Text = resultMessage; // Afficher le message d'erreur retourné par l'API
            }
        }
        private async Task<string> AjouterSalle(AjoutSalleDTO Salle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Salle), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/Salles/AjoutSalle", content);

            if (response.IsSuccessStatusCode)
            {
                return string.Empty; // Opération réussie
            }
            else
            {
                // Lire le contenu de la réponse pour obtenir le message d'erreur
                var errorContent = await response.Content.ReadAsStringAsync();
                return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de l'ajout de la salle.";
            }
        }
        private async Task<string> ModifierSalle(MajSalleDTO salle)
        {
            var content = new StringContent(JsonConvert.SerializeObject(salle), Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7013/Admin/Salles/MajSalle/" + salle.sa_id, content);

            if (response.IsSuccessStatusCode)
            {
                return string.Empty; // Opération réussie
            }
            else
            {
                // Lire le contenu de la réponse pour obtenir le message d'erreur
                var errorContent = await response.Content.ReadAsStringAsync();
                return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de la modification de la salle.";
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
            if (MessageBox.Show("Voulez-vous quitter sans enregistrer les modifications ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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
