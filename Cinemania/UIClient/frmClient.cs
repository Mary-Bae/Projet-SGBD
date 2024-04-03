using Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace UIClient
{
    public partial class frmClient : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public frmClient()
        {
            InitializeComponent();
            LoadFilms();
            LoadCinemas();
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
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Client/Films");
                    success = response.IsSuccessStatusCode;
                    if (success)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var films = JsonConvert.DeserializeObject<BindingList<FilmsDTO>>(responseContent);
                        dgvFilm.DataSource = films;
                        dgvFilm.Columns["fi_id"].Visible = false;
                        dgvFilm.Columns["fi_nom"].HeaderText = "Titre";
                        dgvFilm.Columns["fi_description"].HeaderText = "Description";
                        dgvFilm.Columns["fi_genre"].HeaderText = "Genre";
                    }
                }
                catch (HttpRequestException)
                {
                    attempts++;
                    if (attempts < maxRetries) await Task.Delay(1000); // Attendre 1 seconde avant de réessayer
                }
            }
            if (!success) MessageBox.Show("Les films disponibles ne savent pas se charger, désolés du désagrément.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void LoadCinemas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Client/Cinemas");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    List<CinemasDTO> cinemas = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseData);

                    cmbCinemas.DataSource = cinemas;
                    cmbCinemas.DisplayMember = "ci_nom";
                    cmbCinemas.ValueMember = "ci_id";
                }
                else
                {
                    MessageBox.Show("Impossible de charger les cinémas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la récupération des cinémas : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCinemas.SelectedItem != null)
            {
                var selectedCinema = (CinemasDTO)cmbCinemas.SelectedItem;
                // Ajoute un saut de ligne avant chaque chiffre
                string formattedAddress = selectedCinema.ci_adresse.Replace("-", "\n");
                lblAdresseCine.Text = formattedAddress;
            }
            
        }

        private async void btCinema_Click(object sender, EventArgs e)
        {
            if (cmbCinemas.SelectedItem != null)
            {
                var selectedCinema = (CinemasDTO)cmbCinemas.SelectedItem;
                try
                {
                    var response = await client.GetAsync("https://localhost:7013/Client/FilmByCinema/" + selectedCinema.ci_id);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var films = JsonConvert.DeserializeObject<List<FilmsDTO>>(content);

                        frmCinema detailsForm = new frmCinema(selectedCinema, films);
                        detailsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors du chargement des films pour le cinéma sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception, show a message, etc.
                    MessageBox.Show($"Une erreur s'est produite: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cinéma.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}