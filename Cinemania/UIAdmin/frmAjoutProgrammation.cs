using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace UIAdmin
{
    public partial class frmAjoutProgrammation : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public int filmId { get; set; }

        public frmAjoutProgrammation()
        {
            InitializeComponent();
            CalProgrammation.MinDate = DateTime.Today;
            ChargerCinemas();
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
                    Console.WriteLine("Erreur lors de la récupération des cinémas : " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue : " + ex.Message);
            }
        }

        private void CalProgrammation_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = CalProgrammation.SelectionStart;
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
        private async void btSave_Click(object sender, EventArgs e)
        {
            int cinemaId = GetSelectedCinemaId(); // Méthode pour récupérer l'ID du cinéma sélectionné
            DateTime dateProgrammation = CalProgrammation.SelectionStart;

            if (dateProgrammation == DateTime.MinValue)
            {
                MessageBox.Show("Veuillez sélectionner une date de programmation.");
                return;
            }

            var programmationData = new
            {
                filmId = this.filmId,
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
                    MessageBox.Show("La programmation du film a été ajoutée avec succès.");
                    this.DialogResult = DialogResult.OK; // Pour indiquer le succès
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
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
                    Console.WriteLine("Échec de la requête : " + statusCode);
                    return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de la requête avec le statut " + statusCode;
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
