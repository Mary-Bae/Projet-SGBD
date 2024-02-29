using Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;

namespace UIAdmin
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _currentChaineId;
        public Form1()
        {
            InitializeComponent();
            LoadChaines();
            CustomizeDataGridView();
        }

        async void LoadChaines()
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/api/Admin/Chaine");

            if (response.IsSuccessStatusCode)
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

        void CustomizeDataGridView()
        {
            dgvChaine.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            dgvChaine.DefaultCellStyle.ForeColor = Color.LightSalmon;
            dgvChaine.DefaultCellStyle.BackColor = Color.Black;

            dgvCine.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            dgvCine.DefaultCellStyle.ForeColor = Color.LightSalmon;
            dgvCine.DefaultCellStyle.BackColor = Color.Black;
        }

        private void dgvChaines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChaine.CurrentRow?.DataBoundItem is ChaineDTO selectedChaine)
            {
                int chaineId = selectedChaine.ch_id;
                LoadCinemasByChaine(chaineId);
            }
        }
        async void LoadCinemasByChaine(int chaineId)
        {
            _currentChaineId = chaineId;
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/api/Admin/CinemasByChaine/" + chaineId);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                dgvCine.DataSource = cinemas;

                dgvCine.Columns["ci_id"].Visible = false;
                dgvCine.Columns["ci_nom"].HeaderText = "Nom du Cinéma";
                dgvCine.Columns["ci_adresse"].HeaderText = "Adresse";
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
            }
        }

        async private void btGetCinemas_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/api/Admin/Cinemas");

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
                MessageBox.Show("Impossible de charger les données des cinémas.");
            }
        }

        async private void btUpdate_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";

            MajCinemasDTO oCinema = new MajCinemasDTO();
            oCinema.ci_id = 1;
            oCinema.ci_nom = "Kinepolis";
            oCinema.ci_adresse = "";
            oCinema.ci_ch_id = 1;

            JsonContent content = JsonContent.Create(oCinema);
            HttpResponseMessage response = await client.GetAsync("https://localhost:7013/api/Admin/Cinemas");

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
            }
        }
        private async void supprimerCinémaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCine.CurrentRow != null)
            {
                int cinemaId = Convert.ToInt32(dgvCine.CurrentRow.Cells["ci_id"].Value);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/api/Admin/Cinemas" + cinemaId);

                if (response.IsSuccessStatusCode)
                {
                    LoadCinemasByChaine(_currentChaineId);
                    dgvCine.Columns["ci_id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("La suppression a échoué.");
                }
            }
        }
        private async Task AjouterNouvelleChaine(AjoutChaineDTO nouvelleChaine)
        {
                StringContent content = new StringContent(JsonConvert.SerializeObject(nouvelleChaine), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://localhost:7013/api/Admin/Chaines", content);

                if (response.IsSuccessStatusCode)
                {
                    LoadChaines();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la nouvelle chaîne. Veuillez réessayer.");
                }   
        }
        private async void dgvChaine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChaine.Columns[e.ColumnIndex].Name == "ch_nom")
            {
                var row = dgvChaine.Rows[e.RowIndex];
                var nouvelleChaineNom = row.Cells["ch_nom"].Value?.ToString();

                // Vérifier si la cellule éditée contient une valeur non nulle et non vide
                if (!string.IsNullOrWhiteSpace(nouvelleChaineNom))
                {
                    AjoutChaineDTO nouvelleChaine = new AjoutChaineDTO { ch_nom = nouvelleChaineNom };
                    await AjouterNouvelleChaine(nouvelleChaine);
                }
            }
        }
    }
}
