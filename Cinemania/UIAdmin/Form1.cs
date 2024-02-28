using Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;

namespace UIAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadChaines();

        }

        async void LoadChaines()
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(sUrlServeur + "/api/Admin/Chaine");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var chaines = JsonConvert.DeserializeObject<List<ChaineDTO>>(responseContent);
                    dgvChaine.DataSource = chaines;

                    dgvChaine.Columns["ch_id"].Visible = false;
                    dgvChaine.Columns["ch_nom"].HeaderText = "Chaine de Cinéma";
                }
            }
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
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{sUrlServeur}/api/Admin/CinemasByChaine/{chaineId}");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                    dgvCine.DataSource = cinemas;

                    dgvCine.Columns["ci_nom"].HeaderText = "Nom du Cinéma";
                    dgvCine.Columns["ci_adresse"].HeaderText = "Adresse";
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }



    async private void btGetCinemas_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(sUrlServeur + "/api/Admin/Cinemas" );
                
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    List<CinemasDTO> data = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                    dgvCine.DataSource = data;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }
        async private void btDelCinemas_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(sUrlServeur + "/api/Admin/Cinemas/14");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
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

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(sUrlServeur + "/api/Admin/Cinemas", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}