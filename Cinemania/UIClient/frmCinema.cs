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
        private int _selectedFilmId;

        private static readonly HttpClient client = new HttpClient();
        public frmCinema(CinemasDTO cinemaDetails, List<FilmsDTO> filmDetails)
        {
            InitializeComponent();
            _cinemaDetails = cinemaDetails;
            _filmDetails = filmDetails;
            lblCinemaNom.Text = _cinemaDetails.ci_nom;
            LoadFilms();
            dateReservation.Enabled = false;
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
                dateReservation.Enabled = false;
                var selectedFilm = _filmDetails[lstFilms.SelectedIndex];
                _selectedFilmId = selectedFilm.fi_id;
                lblDescription.Text = selectedFilm.fi_description;
                lblGenre.Text = selectedFilm.fi_genre;
                await GetLanguesPourFilm(_cinemaDetails.ci_id, _selectedFilmId);
            }
        }

        private async Task<List<LangueAndHoraireDTO>> GetLanguesPourFilm(int cinemaId,int filmId)
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
                    item.Tag = langue.la_id;
                    lstLangue.Items.Add(item);
                }
                return langues;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des langues pour le film sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<LangueAndHoraireDTO>();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter sans réserver ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private async void lstLangue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLangue.SelectedIndices.Count > 0 && _selectedFilmId != 0)
            {
                var selectedItem = lstLangue.SelectedItems[0];
                int langueId = Convert.ToInt32(selectedItem.Tag);  // Langue
                var horaire = selectedItem.SubItems[2].Text; // Horaire

                await GetPlageDeDates(_selectedFilmId, _cinemaDetails.ci_id, langueId, horaire);
            }
        }

        private async Task GetPlageDeDates(int filmId, int cinemaId, int langueId, string horaire)
        {
            var response = await client.GetAsync($"https://localhost:7013/Client/GetDatesByProjection/{filmId}/{cinemaId}/{langueId}/{horaire}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var dates = JsonConvert.DeserializeObject<DatesDTO>(content);

                var minDate = dates.DateDebut > DateTime.Today ? dates.DateDebut : DateTime.Today;

                dateReservation.MinDate = minDate;
                dateReservation.MaxDate = dates.DateFin;
                dateReservation.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération de la plage de dates.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<SalleDTO> GetDetailsSalle(int cinemaId, int filmId, int langueId, string horaire, DateTime dateSelectionnee)
        {
            string formattedDate = dateSelectionnee.ToString("yyyy-MM-dd");
            var response = await client.GetAsync($"https://localhost:7013/Client/SalleByProjection?CinemaId={cinemaId}&FilmId={filmId}&LangueId={langueId}&Horaire={horaire}&Date={formattedDate}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var salleDetails = JsonConvert.DeserializeObject<SalleDTO>(content);
                return salleDetails;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des détails de la salle.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void btReserver_Click(object sender, EventArgs e)
        {
            if (lstLangue.SelectedItems.Count > 0)
            {
                var selectedItem = lstLangue.SelectedItems[0];
                int langueId = Convert.ToInt32(selectedItem.Tag);
                string horaire = selectedItem.SubItems[2].Text;

                DateTime dateSelectionnee = dateReservation.Value;

                SalleDTO salleDetails = await GetDetailsSalle(_cinemaDetails.ci_id, _selectedFilmId, langueId, horaire, dateSelectionnee);

                ReservationDetailsDTO reservationDetails = new ReservationDetailsDTO
                {
                    CinemaId = _cinemaDetails.ci_id,
                    CinemaNom = _cinemaDetails.ci_nom,
                    FilmId = _selectedFilmId,
                    LangueId = langueId,
                    Horaire = horaire,
                    DateSelectionnee = dateSelectionnee,
                    SalleDetails = salleDetails
                };

                frmReservation reservationForm = new frmReservation(reservationDetails);
                reservationForm.Owner = this;
                reservationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un film ainsi qu'une séance pour continuer.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
