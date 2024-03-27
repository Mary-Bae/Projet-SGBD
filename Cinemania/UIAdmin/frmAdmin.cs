using Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

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
            LoadFilms();
            ChargerCinemas();
            LoadProgrammationData();
            LoadLangues();
            CalProgrammation.MinDate = DateTime.Today;
        }
        async void LoadChaines()
        {
            const int maxRetries = 3;
            int attempts = 0;
            bool success = false;

            //Recharge les chaines en trois tentatives si elles n'arrivent pas � se charger, ca laisse le temps � l'API de se charger
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
                        dgvChaine.Columns["ch_nom"].HeaderText = "Chaine de Cin�ma";
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de r�essayer
                }
            }
            if (!success) MessageBox.Show("Impossible de charger les donn�es apr�s plusieurs tentatives.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        async void LoadFilms()
        {
            const int maxRetries = 3;
            int attempts = 0;
            bool success = false;

            while (attempts < maxRetries && !success)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Films");
                    success = response.IsSuccessStatusCode;
                    if (success)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var films = JsonConvert.DeserializeObject<BindingList<FilmsDTO>>(responseContent);
                        dgvFilms.DataSource = films;
                        dgvFilms.Columns["fi_id"].Visible = false;
                        dgvFilms.Columns["fi_nom"].HeaderText = "Titre";
                        dgvFilms.Columns["fi_genre"].HeaderText = "Genre";
                        dgvFilms.Columns["fi_description"].Visible = false; ;
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de r�essayer
                }
            }
            if (!success) MessageBox.Show("Impossible de charger les donn�es apr�s plusieurs tentatives.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void ChargerCinemas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Cinemas");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        List<CinemasDTO> data = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);

                        foreach (CinemasDTO cinema in data)
                        {
                            cmbCine.Items.Add(cinema);
                        }

                        cmbCine.DisplayMember = "ci_nom";
                    }
                }
                else
                {
                    Console.WriteLine("Erreur lors de la r�cup�ration des cin�mas : " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue : " + ex.Message);
            }
        }

        async void LoadLangues()
        {
            const int maxRetries = 3;
            int attempts = 0;
            bool success = false;

            //Recharge les langues en trois tentatives si elles n'arrivent pas � se charger, ca laisse le temps � l'API de se charger
            while (attempts < maxRetries && !success)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Langues");
                    success = response.IsSuccessStatusCode;
                    if (success)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var langues = JsonConvert.DeserializeObject<BindingList<LangueDTO>>(responseContent);
                        dgvLangues.DataSource = langues;
                        dgvLangues.Columns["la_id"].Visible = false;
                        dgvLangues.Columns["la_langue"].HeaderText = "trad";
                        dgvLangues.Columns["la_sousTitre"].HeaderText = "str";
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de r�essayer
                }
            }
            if (!success) MessageBox.Show("Impossible de charger les donn�es apr�s plusieurs tentatives.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Charge les cinemas associ�s aux chaines � chaque s�lection de chaine
        private async void dgvChaines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow?.DataBoundItem is ChaineDTO selectedChaine)
            {
                lblStatusAdminCinema.Text = "";
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
                dgvCine.Columns["ci_nom"].HeaderText = "Nom du Cin�ma";
                dgvCine.Columns["ci_adresse"].HeaderText = "Adresse";

                return cinemas;
            }
            else
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Les cinemas n'ont pas pu �tre charg�s. D�tails : " + responseContent);
                return new List<CinemasDTO>();
            }
        }

        private async Task MettreAJourChaine(ChaineDTO chaine)
        {
            lblStatusAdminCinema.Text = "";

            StringContent content = new StringContent(JsonConvert.SerializeObject(chaine), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync("https://localhost:7013/Admin/Chaine/MajChaines/" + chaine.ch_id, content);

            if (response.IsSuccessStatusCode)
            {
                LoadChaines();
            }
            else
            {
                
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseContent, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadChaines();
            }
        }
        private async Task SupprimerChaineEtCinemas(int chaineId)
        {
            var confirmResult = MessageBox.Show("�tes-vous s�r de vouloir supprimer cette cha�ne et tous les cin�mas associ�s ?","Confirmer la suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                 // Obtient la liste des cin�mas appartenant � la cha�ne
                 var cinemas = await LoadCinemasByChaine(chaineId);

                // Supprime chaque cin�ma et leurs salles
                foreach (var cinema in cinemas)
                {
                    HttpResponseMessage responseCinema = await client.DeleteAsync("https://localhost:7013/Admin/Cinemas/DelCinemas/" + cinema.ci_id);
                    if (!responseCinema.IsSuccessStatusCode)
                    {
                        // Gestion des erreurs pour chaque cin�ma, arr�tera le processus
                        string responseContent = await responseCinema.Content.ReadAsStringAsync();
                        MessageBox.Show(responseContent, "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Une fois tous les cin�mas supprim�s, suppression de la cha�ne
                HttpResponseMessage responseChaine = await client.DeleteAsync("https://localhost:7013/Admin/Chaine/DelChaines/" + chaineId);
                if (responseChaine.IsSuccessStatusCode)
                {

                    MessageBox.Show("Cha�ne et tous les cin�mas associ�s supprim�s avec succ�s.", "Suppression R�ussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChaines();
                }
                else
                {
                    MessageBox.Show("�chec de la suppression de la cha�ne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void supprimerChaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow != null)
            {
                lblStatusAdminCinema.Text = "";
                int chaineId = Convert.ToInt32(dgvChaine.CurrentRow.Cells["ch_id"].Value);
                await SupprimerChaineEtCinemas(chaineId);
            }
            else
            {
                lblStatusAdminCinema.Text = "Aucune cha�ne n'a �t� s�lectionn�e. Veuillez choisir la cha�ne � supprimer.";
            }
        }

        async private void btGetCinemas_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Cinemas");

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(responseContent))
                {
                    var data = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                    dgvCine.DataSource = data ?? new List<CinemasDTO>(); // l'op�rateur ?? fournira une liste vide en cas de null
                }
                else
                {
                    dgvCine.DataSource = new List<CinemasDTO>();
                }
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Nous rencontrons un probl�me pour charger les donn�es des cin�mas. D�tail technique : " + responseContent, "Erreur de Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private async void supprimerCin�maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";
            if (dgvCine.CurrentRow != null)
            {
                int cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);
                int nombreCinemas = await CompterCinemasByChaine(_currentChaineId);

                if (nombreCinemas <= 1) // Si c'est le dernier cin�ma de la cha�ne, emp�cher la suppression
                {
                    lblStatusAdminCinema.Text = "Vous ne pouvez pas supprimer le dernier cin�ma de la cha�ne.";
                }
                else // S'il y a plus d'un cin�ma, demander confirmation avant suppression
                {
                    var confirmResult = MessageBox.Show("�tes-vous s�r de vouloir supprimer le cin�ma ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Cinemas/DelCinemas/" + cinemaId);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Cin�mas supprim� avec succ�s.", "Suppression R�ussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadCinemasByChaine(_currentChaineId);
                            dgvCine.Columns["ci_id"].Visible = false;
                        }
                        else
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseContent, "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                lblStatusAdminCinema.Text = "Veuillez s�lectionner un cin�ma � supprimer.";
            }
        }

        private async Task<int> CompterCinemasByChaine(int cinemaId)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/CinemasByChaine/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseString);
                    return cinemas.Count; // Retourne le nombre total de cinemas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Erreur de R�cup�ration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0; // Retourne 0 en cas d'erreur
        }
        private void btAjoutercinema_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            if (dgvChaine.CurrentRow != null)
            {
                int chaineId = Convert.ToInt32(dgvChaine.CurrentRow.Cells["ch_id"].Value);

                var formAjoutCinema = new frmAjoutCinema();
                formAjoutCinema.ChaineId = chaineId;

                var result = formAjoutCinema.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Raffraichir les cinemas apr�s le rajout
                    Task<List<CinemasDTO>> task = LoadCinemasByChaine(chaineId);
                }
            }
            else
            {
                lblStatusAdminCinema.Text = "S�lectionnez une chaine de cin�ma pour pouvoir lui attribuer un nouveau cin�ma";
            }
        }

        private void dgvCine_SelectionChanged(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

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
                dgvSalles.Columns["sa_numeroSalle"].HeaderText = "Num�ro de salle";
                dgvSalles.Columns["sa_qtePlace"].HeaderText = "Nombre de places";
                dgvSalles.Columns["sa_qteRangees"].HeaderText = "Nombre de rang�es";
                dgvSalles.Columns["sa_ci_id"].Visible = false;
            }
            else
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Nous rencontrons un probl�me pour charger les salles de cin�ma. D�tail technique : " + responseContent, "Probl�me de Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btAddSalle_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            if (dgvCine.CurrentRow != null)
            {
                var cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);

                var formAjoutSalle = new frmAddUpdSalle(cinemaId, frmAddUpdSalle.Mode.Ajout);

                var result = formAjoutSalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Rafra�chir la liste des salles pour le cin�ma s�lectionn�
                    LoadSallesByCinema(cinemaId);
                }
            }
            else
            {
                lblStatusAdminCinema.Text = "Vous devez s�lectionner un cin�ma de la liste afin de lui attribuer une salle.";

            }
        }

        private async void supprimerSalleDeCinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            if (dgvSalles.CurrentRow != null)
            {
                int salleId = Convert.ToInt32(dgvSalles.CurrentRow.Cells["sa_id"].Value);
                int nombreSalles = await CompterSallesByCinema(_currentCinemaId);

                if (nombreSalles > 1) // Si il y a plus d'une salle, on fait le delete,
                                      // sinon le delete ne se fera pas
                {
                    var confirmResult = MessageBox.Show("�tes-vous s�r de vouloir supprimer cette salle de cin�ma ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Salles/DelSalle/" + salleId);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Salle de cin�ma supprim�e avec succ�s.", "Suppression R�ussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSallesByCinema(_currentCinemaId);
                           // dgvSalles.Columns["sa_id"].Visible = false;
                        }
                        else
                        {
                            var responseContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Nous n'avons pas r�ussi � supprimer l'�l�ment s�lectionn�. D�tail technique : " + responseContent, "�chec de la Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    lblStatusAdminCinema.Text = "La derni�re salle du cin�ma ne peut �tre supprim�e. Chaque cin�ma doit conserver au moins une salle.";
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
                MessageBox.Show("Nous avons rencontr� un probl�me lors de la tentative de r�cup�ration des informations sur les salles. D�tail technique : " + ex.Message, "Erreur de R�cup�ration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0; // Retourne 0 en cas d'erreur
        }

        //Permet de r�cuperer les d�tails de la salle de cin�ma pour qu'ils s'affichent dans les textbox lors de l'ouverture de la forme pour la modification de la salle
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
                    MessageBox.Show("Nous n'avons pas pu charger les d�tails de la salle s�lectionn�e en raison d'un probl�me technique. D�tail de l'erreur : " + responseContent, "Erreur de Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nous avons rencontr� un probl�me lors de la tentative de r�cup�ration des informations sur la salle. D�tail technique : " + ex.Message, "Erreur de R�cup�ration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        private void btAddChaine_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            var frmAjoutChaine = new frmAjoutChaine();
            var result = frmAjoutChaine.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadChaines();
            }
        }
        private async void dgvChaine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            if (e.RowIndex >= 0)
            {
                var row = dgvChaine.Rows[e.RowIndex];
                var cellValue = row.Cells[e.ColumnIndex].Value?.ToString();

                if (dgvChaine.Columns[e.ColumnIndex].Name == "ch_nom")
                {
                    // Si la cellule est vide, afficher un message d'erreur
                    if (string.IsNullOrWhiteSpace(cellValue))
                    {
                        MessageBox.Show("Le champ ne peut pas �tre vide.", "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadChaines();
                        return;
                    }

                    if (MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // V�rifie si l'ID est disponible et valide pour une mise � jour
                        if (int.TryParse(row.Cells["ch_id"].Value?.ToString(), out int chaineId) && chaineId > 0)
                        {
                            ChaineDTO chaineAMettreAJour = new ChaineDTO { ch_id = chaineId, ch_nom = cellValue };
                            await MettreAJourChaine(chaineAMettreAJour);
                        }
                    }
                    else
                    {
                        LoadChaines();
                    }
                }
            }
        }
        private void btUpdateCine_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

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
                lblStatusAdminCinema.Text = "Vous devez s�lectionner un cin�ma de la liste afin de pouvoir le modifier.";
            }
        }
        private async void btUpdateSalle_Click(object sender, EventArgs e)
        {
            lblStatusAdminCinema.Text = "";

            if (dgvSalles.CurrentRow != null)
            {
                int salleId = Convert.ToInt32(dgvSalles.CurrentRow.Cells["sa_id"].Value);
                SalleDTO salleDetails = await GetSalleDetails(salleId);

                if (salleDetails != null)
                {
                    // Ouvre le formulaire frmAjoutSalle en mode Modification avec les d�tails de la salle
                    var formAjoutSalle = new frmAddUpdSalle(salleDetails.sa_ci_id, frmAddUpdSalle.Mode.Modification, salleDetails);
                    var result = formAjoutSalle.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Rafra�chir la liste des salles pour le cin�ma associ�
                        LoadSallesByCinema(salleDetails.sa_ci_id);
                    }
                }
            }
            else
            {
                lblStatusAdminCinema.Text = "Vous devez s�lectionner une salle de la liste pour pouvoir la modifier.";
            }
        }
        private void CalProgrammation_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = CalProgrammation.SelectionStart;
        }
        private int GetSelectedFilmId()
        {
            if (dgvFilms.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvFilms.SelectedRows[0].Cells["fi_id"].Value);
            }
            else
            {
                return -1;
            }
        }
        private int GetSelectedCinemaId()
        {
            if (cmbCine.SelectedItem != null && cmbCine.SelectedItem is CinemasDTO selectedCinema)
            {
                int id = selectedCinema.ci_id;
                return id;
            }
            else
            {
                return -1;
            }
        }
        private int GetSelectedLangueId()
        {
            if (dgvLangues.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgvLangues.SelectedRows[0].Cells["la_id"].Value);
            }
            else
            {
                return -1;
            }
        }
        private async void btProgram_Click(object sender, EventArgs e)
        {
            lblStatusProgrammation.Text = "";

            int filmId = GetSelectedFilmId();
            int cinemaId = GetSelectedCinemaId();
            DateTime dateProgrammation = CalProgrammation.SelectionStart;

            if (CalProgrammation.SelectionStart == DateTime.MinValue)
            {
                lblStatusProgrammation.Text = "Veuillez s�lectionner une date de programmation.";
                return;
            }

            var programmationData = new
            {
                filmId = filmId,
                cinemaId = cinemaId,
                dateProgrammation = dateProgrammation
            };

            try
            {
                string jsonData = JsonConvert.SerializeObject(programmationData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var errorMessage = await AjouterProgrammation(content);

                if (string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show("La programmation du film a �t� ajout�e avec succ�s.", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProgrammationData();
                    cmbCine.SelectedIndex = -1;
                    cmbCine.Text = "Selection cinemas";
                }
                else
                {
                    lblStatusProgrammation.Text = errorMessage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<string> AjouterProgrammation(StringContent content)
        {
            try
            {
                var response = await client.PostAsync("https://localhost:7013/Admin/Programmation/AddProgrammation", content);

                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var statusCode = response.StatusCode;
                    Console.WriteLine("�chec de la requ�te : " + statusCode);
                    return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "�chec de la requ�te avec le statut " + statusCode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue : " + ex.Message);
                return "Une erreur inattendue est survenue.";
            }
        }

        private async void LoadProgrammationData()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Programmation");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    List<ProgrammationAvecNomsDTO> programmations = JsonConvert.DeserializeObject<List<ProgrammationAvecNomsDTO>>(responseData);

                    dgvProgrammation.DataSource = programmations;
                    dgvProgrammation.Columns["pr_id"].Visible = false;
                    dgvProgrammation.Columns["fi_Nom"].HeaderText = "Film";
                    dgvProgrammation.Columns["ci_Nom"].HeaderText = "Cinema";
                    dgvProgrammation.Columns["pr_date"].HeaderText = "Date Programm�e";
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de la r�cup�ration des donn�es de programmation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
        private async void supprimerProgrammationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatusProgrammation.Text = "";

            if (dgvProgrammation.CurrentRow != null)
            {
                int programmationId = Convert.ToInt32(dgvProgrammation.CurrentRow.Cells["pr_id"].Value);
                var confirmResult = MessageBox.Show("�tes-vous s�r de vouloir supprimer cette programmation ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Programmation/DelProgrammation/" + programmationId);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Programmation supprim�e avec succ�s.", "Suppression R�ussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProgrammationData();
                        }
                        else
                        {
                            var responseContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Nous n'avons pas r�ussi � supprimer l'�l�ment s�lectionn�. D�tail technique : " + responseContent, "�chec de la Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }

        private void btAddFilm_Click(object sender, EventArgs e)
        {
            lblStatusProgrammation.Text = "";

            var formAjoutFilm = new frmAddUpdFilm(frmAddUpdFilm.Mode.Ajout);
            var result = formAjoutFilm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFilms();
            }
        }

        private async void btUpdFilm_Click(object sender, EventArgs e)
        {
            lblStatusProgrammation.Text = "";

            if (dgvFilms.CurrentRow != null)
            {
                int filmId = Convert.ToInt32(dgvFilms.CurrentRow.Cells["fi_id"].Value);
                FilmsDTO filmDetails = await GetFilmDetails(filmId);

                if (filmDetails != null)
                {
                    // Ouvre le formulaire frmAjoutSalle en mode Modification avec les d�tails de la salle
                    var formAjoutFilm = new frmAddUpdFilm(frmAddUpdFilm.Mode.Modification, filmDetails);
                    var result = formAjoutFilm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        LoadFilms();
                    }
                }
            }
            else
            {
                lblStatusProgrammation.Text = "Vous devez s�lectionner une salle de la liste pour pouvoir la modifier.";
            }
        }

        private async Task<FilmsDTO?> GetFilmDetails(int filmId)
        {
            try
            {
                var response = await client.GetAsync("https://localhost:7013/Admin/FilmByFilmId/" + filmId);

                if (response.IsSuccessStatusCode)
                {
                    var filmJson = await response.Content.ReadAsStringAsync();
                    var filmDetails = JsonConvert.DeserializeObject<FilmsDTO>(filmJson);
                    return filmDetails;
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseContent, "Erreur de Chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Erreur de R�cup�ration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private async void supprimerFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatusProgrammation.Text = "";
            if (dgvFilms.CurrentRow != null)
            {
                int filmId = Convert.ToInt32(dgvFilms.CurrentRow.Cells["fi_id"].Value);
                var confirmResult = MessageBox.Show("�tes-vous s�r de vouloir supprimer ce film ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Films/DelFilm/" + filmId);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Film supprim� avec succ�s.", "Suppression R�ussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFilms();
                    }
                    else
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseContent, "�chec de la Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btTrad_Click(object sender, EventArgs e)
        {
            int filmId = GetSelectedFilmId();
            int langueId = GetSelectedLangueId();

            if (filmId == -1 || langueId == -1)
            {
                MessageBox.Show("Veuillez s�lectionner un film et une langue.");
                return;
            }

            var traductionData = new
            {
                FilmId = filmId,
                LangueId = langueId
            };

            try
            {
                string jsonData = JsonConvert.SerializeObject(traductionData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var errorMessage = await AjouterTraduction(content);

                if (string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show("Traduction ajout�e avec succ�s.", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async Task<string> AjouterTraduction(StringContent content)
        {
            try
            {
                var response = await client.PostAsync("https://localhost:7013/Admin/Traduction/AddTraduction", content);

                if (response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "�chec de la requ�te.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue : " + ex.Message);
                return "Une erreur inattendue est survenue.";
            }
        }
    }
    }


