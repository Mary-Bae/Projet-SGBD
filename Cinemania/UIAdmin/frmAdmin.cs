using Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;

namespace UIAdmin
{
    public partial class frmAdmin : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _currentChaineId;
        private int _currentCinemaId;
        public frmAdmin()
        {
            InitializeComponent();
            LoadChaines();
        }

        async void LoadChaines()
        {
            const int maxRetries = 3;
            int attempts = 0;
            bool success = false;

            //Recharge les chaines en trois tentatives si elles n'arrivent pas à se charger, ca laisse le temps à l'API de se charger
            while (attempts < maxRetries && !success)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Chaine");
                    success = response.IsSuccessStatusCode;
                    if (success)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var chaines = JsonConvert.DeserializeObject<BindingList<ChaineDTO>>(responseContent);
                        dgvChaine.DataSource = chaines;

                        dgvChaine.Columns["ch_id"].Visible = false;
                        dgvChaine.Columns["ch_nom"].HeaderText = "Chaine de Cinéma";

                        foreach (DataGridViewColumn column in dgvChaine.Columns)
                        {
                            column.ReadOnly = false;
                        }
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de réessayer
                }
            }
            if (!success) MessageBox.Show("Impossible de charger les données après plusieurs tentatives.");
        }

        //Charge les cinemas associés aux chaines à chaque sélection de chaine
        private async void dgvChaines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow?.DataBoundItem is ChaineDTO selectedChaine)
            {
                int chaineId = selectedChaine.ch_id;
                await LoadCinemasByChaine(chaineId);
            }
        }
        private async Task<List<CinemasDTO>> LoadCinemasByChaine(int chaineId)
        {
            _currentChaineId = chaineId;
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/CinemasByChaine/" + chaineId);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                dgvCine.DataSource = cinemas;

                dgvCine.Columns["ci_id"].Visible = false;
                dgvCine.Columns["ci_nom"].HeaderText = "Nom du Cinéma";
                dgvCine.Columns["ci_adresse"].HeaderText = "Adresse";

                return cinemas;
            }
            else
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Les cinemas n'ont pas pu être chargés. Détails : " + responseContent);
                return new List<CinemasDTO>();
            }
        }
        //private async Task AjouterNouvelleChaine(AjoutChaineDTO nouvelleChaine)
        //{
        //    StringContent content = new StringContent(JsonConvert.SerializeObject(nouvelleChaine), Encoding.UTF8, "application/json");
        //    HttpResponseMessage response = await client.PostAsync("https://localhost:7013/Admin/Chaine/AddChaines/", content);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        LoadChaines(); // Rafraîchir les données après l'ajout pour s'assurer que les ID sont corrects
        //    }
        //    else
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        MessageBox.Show("Erreur lors de l'ajout de la nouvelle chaîne. Détails : " + responseContent);
        //    }
        //}

        private async Task MettreAJourChaine(ChaineDTO chaine)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(chaine), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync("https://localhost:7013/Admin/Chaine/MajChaines/" + chaine.ch_id, content);

            if (response.IsSuccessStatusCode)
            {
                LoadChaines();
            }
            else
            {
                
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Erreur lors de la mise à jour de la chaîne. Détails : " + responseContent);
            }
        }

        private async void dgvChaine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChaine.Columns[e.ColumnIndex].Name == "ch_nom")
            {
                var row = dgvChaine.Rows[e.RowIndex];
                var chaineNom = row.Cells["ch_nom"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(chaineNom))
                {
                    // Vérifie si l'ID est disponible et valide pour une mise à jour
                    if (int.TryParse(row.Cells["ch_id"].Value?.ToString(), out int chaineId) && chaineId > 0)
                    {
                        ChaineDTO chaineAMettreAJour = new ChaineDTO { ch_id = chaineId, ch_nom = chaineNom };
                        await MettreAJourChaine(chaineAMettreAJour);
                    }
                }
            }
        }
        private async Task SupprimerChaineEtCinemas(int chaineId)
        {
            // Obtient la liste des cinémas appartenant à la chaîne
            var cinemas = await LoadCinemasByChaine(chaineId);

            // Supprime chaque cinéma et leurs salles
            foreach (var cinema in cinemas)
            {
                HttpResponseMessage responseCinema = await client.DeleteAsync($"https://localhost:7013/Admin/Cinemas/DelCinemas/{cinema.ci_id}");
                if (!responseCinema.IsSuccessStatusCode)
                {
                    // Gestion des erreurs pour chaque cinéma, arrêtera le processus
                    MessageBox.Show("Échec de la suppression du cinéma ID : " + cinema.ci_id + ". Processus interrompu.");
                    return;
                }
            }

            // Une fois tous les cinémas supprimés, suppression de la chaîne
            HttpResponseMessage responseChaine = await client.DeleteAsync("https://localhost:7013/Admin/Chaine/DelChaines/" + chaineId);
            if (responseChaine.IsSuccessStatusCode)
            {
                MessageBox.Show("Chaîne et tous les cinémas associés supprimés avec succès.");
                LoadChaines();
            }
            else
            {
                MessageBox.Show("Échec de la suppression de la chaîne.");
            }
        }
        private async void supprimerChaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow != null)
            {
                int chaineId = Convert.ToInt32(dgvChaine.CurrentRow.Cells["ch_id"].Value);
                await SupprimerChaineEtCinemas(chaineId);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chaîne à supprimer.");
            }
        }

        async private void btGetCinemas_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Cinemas");

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(responseContent))
                {
                    var data = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                    dgvCine.DataSource = data ?? new List<CinemasDTO>(); // l'opérateur ?? fournira une liste vide en cas de null
                }
                else
                {
                    dgvCine.DataSource = new List<CinemasDTO>();
                }
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Impossible de charger les données des cinémas. Details : " + responseContent);
            }
        }
        private async void supprimerCinémaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow != null)
            {
                int cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);
                HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Cinemas/DelCinemas/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    await LoadCinemasByChaine(_currentChaineId);
                    dgvCine.Columns["ci_id"].Visible = false;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("La suppression a échoué. Details : " + responseContent);
                }
            }
        }

        private void btAjoutercinema_Click(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow != null)
            {
                int chaineId = Convert.ToInt32(dgvChaine.CurrentRow.Cells["ch_id"].Value);

                var formAjoutCinema = new frmAjoutCinema();
                formAjoutCinema.ChaineId = chaineId;

                var result = formAjoutCinema.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Raffraichir les cinemas après le rajout
                    Task<List<CinemasDTO>> task = LoadCinemasByChaine(chaineId);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chaîne.");
            }
        }

        private void dgvCine_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow?.DataBoundItem is CinemasDTO selectedCinema)
            {
                int cinemaId = selectedCinema.ci_id;
                LoadSallesByCinema(cinemaId);
            }
        }
        private async void LoadSallesByCinema(int cinemaId)
        {
            _currentCinemaId = cinemaId;
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/SallesByCinema/" + cinemaId);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var salles = JsonConvert.DeserializeObject<List<SalleDTO>>(responseContent);
                //dgvSalles.AutoGenerateColumns = true;
                dgvSalles.DataSource = salles;

                dgvSalles.Columns["sa_id"].Visible = false;
                dgvSalles.Columns["sa_numeroSalle"].HeaderText = "Numéro de salle";
                dgvSalles.Columns["sa_qtePlace"].HeaderText = "Nombre de places";
                dgvSalles.Columns["sa_qteRangees"].HeaderText = "Nombre de rangées";
                dgvSalles.Columns["sa_ci_id"].Visible = false;
            }
            else
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Les salles de cinema n'ont pas pu être chargées. Details : " + responseContent);
            }
        }
        private void btAddSalle_Click(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow != null)
            {
                var cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);

                var formAjoutSalle = new frmAddUpdSalle(cinemaId, frmAddUpdSalle.Mode.Ajout);

                var result = formAjoutSalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Rafraîchir la liste des salles pour le cinéma sélectionné
                    LoadSallesByCinema(cinemaId);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cinéma.");
            }
        }

        private async void supprimerSalleDeCinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSalles.CurrentRow != null)
            {
                int salleId = Convert.ToInt32(dgvSalles.CurrentRow.Cells["sa_id"].Value);
                int nombreSalles = await CompterSallesByCinema(_currentCinemaId);

                if (nombreSalles > 1) // Si il y a plus d'une salle, on fait le delete,
                                      // sinon le delete ne se fera pas
                {
                    HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Salles/DelSalle/" + salleId);

                    if (response.IsSuccessStatusCode)
                    {
                        LoadSallesByCinema(_currentCinemaId);
                        dgvSalles.Columns["sa_id"].Visible = false;
                    }
                    else
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("La suppression a échoué. Details : " + responseContent);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer la dernière salle du cinéma.");
                }
            }
        }
        private async Task<int> CompterSallesByCinema(int cinemaId)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/SallesByCinema/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var salles = JsonConvert.DeserializeObject<List<SalleDTO>>(responseString);
                    return salles.Count; // Retourne le nombre total de salles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des salles : " + ex.Message);
            }
            return 0; // Retourne 0 en cas d'erreur
        }

        private async void modifierSalleDeCinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSalles.CurrentRow != null)
            {
                int salleId = Convert.ToInt32(dgvSalles.CurrentRow.Cells["sa_id"].Value);
                SalleDTO salleDetails = await GetSalleDetails(salleId);

                if (salleDetails != null)
                {
                    // Ouvre le formulaire frmAjoutSalle en mode Modification avec les détails de la salle
                    var formAjoutSalle = new frmAddUpdSalle(salleDetails.sa_ci_id, frmAddUpdSalle.Mode.Modification, salleDetails);
                    var result = formAjoutSalle.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Rafraîchir la liste des salles pour le cinéma associé
                        LoadSallesByCinema(salleDetails.sa_ci_id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une salle à modifier.");
            }
        }

        //Permet de récuperer les détails de la salle de cinéma pour qu'ils s'affichent dans les textbox lors de l'ouverture de la forme pour la modification de la salle
        private async Task<SalleDTO?> GetSalleDetails(int salleId) 
        {
            try
            {
                var response = await client.GetAsync("https://localhost:7013/Admin/SalleBySalleId/" + salleId);

                if (response.IsSuccessStatusCode)
                {
                    var salleJson = await response.Content.ReadAsStringAsync();
                    var salleDetails = JsonConvert.DeserializeObject<SalleDTO>(salleJson);
                    return salleDetails;
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Impossible de récupérer les détails de la salle. Details : " + responseContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des détails de la salle : " + ex.Message);
            }

            return null;
        }

        private void modifierCinémaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow != null)
            {
                var selectedRow = dgvCine.CurrentRow;
                var selectedCinema = new MajCinemasDTO
                {
                    ci_id = Convert.ToInt32(selectedRow.Cells["ci_id"].Value),
                    ci_nom = Convert.ToString(selectedRow.Cells["ci_nom"].Value),
                    ci_adresse = Convert.ToString(selectedRow.Cells["ci_adresse"].Value),
                    ci_ch_id = _currentChaineId
                };

                using (var frm = new frmUpdateCinema(selectedCinema))
                {
                    var result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Task<List<CinemasDTO>> task = LoadCinemasByChaine(_currentChaineId);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cinéma à modifier.");
            }
        }
    }
}

