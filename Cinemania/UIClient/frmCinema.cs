using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIClient
{
    public partial class frmCinema : Form
    {
        private CinemasDTO _cinemaDetails;
        private List<FilmsDTO> _filmDetails;

        private static readonly HttpClient client = new HttpClient();
        public frmCinema(CinemasDTO cinemaDetails, List<FilmsDTO> filmDetails)
        {
            InitializeComponent();
            _cinemaDetails = cinemaDetails;
            _filmDetails = filmDetails;
            lblCinemaNom.Text = _cinemaDetails.ci_nom;
            LoadFilms();
        }

        private void LoadFilms()
        {
            foreach (var film in _filmDetails)
            {
                lstFilms.Items.Add(film.fi_nom);
            }
        }

        private async void lstFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilms.SelectedIndex != -1)
            {
                var selectedFilm = _filmDetails[lstFilms.SelectedIndex];
                lblDescription.Text = selectedFilm.fi_description;
                lblGenre.Text = selectedFilm.fi_genre;
                await GetLanguesPourFilm(_cinemaDetails.ci_id, selectedFilm.fi_id);
            }
        }

        private async Task<List<LangueAndHoraireDTO>> GetLanguesPourFilm(int filmId, int cinemaId)
        {
            var response = await client.GetAsync($"https://localhost:7013/Client/LangueByFilmAndCinema/{cinemaId}/{filmId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var langues = JsonConvert.DeserializeObject<List<LangueAndHoraireDTO>>(content);

                lstLangue.Items.Clear();
                foreach (var langue in langues)
                {
                    var item = new ListViewItem(new[] { langue.la_langue, langue.la_sousTitre, langue.se_horaire });
                    lstLangue.Items.Add(item);
                }
                return langues;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des langues pour le film sélectionné.");
                return new List<LangueAndHoraireDTO>();
            }
        }
    }
}
