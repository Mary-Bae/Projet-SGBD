using Models;
using Newtonsoft.Json;
using System.ComponentModel;

namespace UIClient
{
    public partial class frmClient : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public frmClient()
        {
            InitializeComponent();
            LoadFilms();
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
    }
}