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
        public frmAdmin()
        {
            InitializeComponent();
            LoadChaines();
            CustomizeDataGridView();
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

                        foreach (DataGridViewColumn column in dgvChaine.Columns)
                        {
                            column.ReadOnly = false;
                        }
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de r�essayer
                }
            }
            if (!success) MessageBox.Show("Impossible de charger les donn�es apr�s plusieurs tentatives.");
        }
        void CustomizeDataGridView()
        {
            dgvChaine.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            dgvChaine.DefaultCellStyle.ForeColor = Color.LightSalmon;
            dgvChaine.DefaultCellStyle.BackColor = Color.Black;

            dgvCine.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            dgvCine.DefaultCellStyle.ForeColor = Color.LightSalmon;
            dgvCine.DefaultCellStyle.BackColor = Color.Black;
        }

        //Charge les cinemas associ�s aux chaines � chaque s�lection de chaine
        private void dgvChaines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow?.DataBoundItem is ChaineDTO selectedChaine)
            {
                int chaineId = selectedChaine.ch_id;
                LoadCinemasByChaine(chaineId);
            }
        }
        async private void LoadCinemasByChaine(int chaineId)
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
            }
            else
            {
                var responseContent = await response.Content.ReadAsStringAsync();
            }
        }
        private async Task AjouterNouvelleChaine(AjoutChaineDTO nouvelleChaine)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(nouvelleChaine), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://localhost:7013/Admin/Chaine/AddChaines/", content);

            if (response.IsSuccessStatusCode)
            {
                LoadChaines(); // Rafra�chir les donn�es apr�s l'ajout pour s'assurer que les ID sont corrects
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de la nouvelle cha�ne. Veuillez r�essayer.");
            }
        }

        private async Task MettreAJourChaine(ChaineDTO chaine)
        {
            // S�rialisez l'objet ChaineDTO en JSON
            StringContent content = new StringContent(JsonConvert.SerializeObject(chaine), Encoding.UTF8, "application/json");

            // Envoyez une requ�te PUT � votre API pour mettre � jour la cha�ne existante
            HttpResponseMessage response = await client.PutAsync("https://localhost:7013/Admin/Chaine/MajChaines/" + chaine.ch_id, content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Erreur lors de la mise � jour de la cha�ne. Veuillez r�essayer.");
            }
            else
            {
                // Optionnellement, vous pouvez confirmer que la mise � jour a r�ussi et rafra�chir la liste des cha�nes
                LoadChaines();
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
                    // V�rifie si l'ID est disponible et valide pour une mise � jour
                    if (int.TryParse(row.Cells["ch_id"].Value?.ToString(), out int chaineId) && chaineId > 0)
                    {
                        ChaineDTO chaineAMettreAJour = new ChaineDTO { ch_id = chaineId, ch_nom = chaineNom };
                        await MettreAJourChaine(chaineAMettreAJour);
                    }
                    else
                    {
                        // Sinon, ce sera un ajout
                        AjoutChaineDTO nouvelleChaine = new AjoutChaineDTO { ch_nom = chaineNom };
                        await AjouterNouvelleChaine(nouvelleChaine);
                    }
                }
            }
        }

        private async void supprimerChaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow != null)
            {
                int chaineId = Convert.ToInt32(dgvChaine.CurrentRow.Cells["ch_id"].Value);
                HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Chaine/DelChaines/" + chaineId);

                if (response.IsSuccessStatusCode)
                {
                    LoadChaines();
                }
                else
                {
                    MessageBox.Show("La suppression de la cha�ne a �chou�.");
                }
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
                MessageBox.Show("Impossible de charger les donn�es des cin�mas.");
            }
        }

        async private void btUpdate_Click(object sender, EventArgs e)
        {
            MajCinemasDTO oCinema = new MajCinemasDTO();
            oCinema.ci_id = 1;
            oCinema.ci_nom = "Kinepolis";
            oCinema.ci_adresse = "";
            oCinema.ci_ch_id = 1;

            JsonContent content = JsonContent.Create(oCinema);
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/Cinemas/MajCinemas");

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
            }
        }
        private async void supprimerCin�maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow != null)
            {
                int cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);
                HttpResponseMessage response = await client.DeleteAsync("https://localhost:7013/Admin/Cinemas/DelCinemas/" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    LoadCinemasByChaine(_currentChaineId);
                    dgvCine.Columns["ci_id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("La suppression a �chou�.");
                }
            }
        }
    }
}
