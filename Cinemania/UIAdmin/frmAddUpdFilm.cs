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
using Newtonsoft.Json;

namespace UIAdmin
{
    public partial class frmAddUpdFilm : Form
    {
        public enum Mode { Ajout, Modification }

        private static readonly HttpClient client = new HttpClient();
        private Mode _modeActuel;
        private FilmsDTO _filmSelectionne;
        public frmAddUpdFilm(Mode mode, FilmsDTO? film = null)
        {
            InitializeComponent();
            _modeActuel = mode;
            _filmSelectionne = film;

            if (_modeActuel == Mode.Modification && _filmSelectionne != null)
            {
                PreremplirChamps(_filmSelectionne);
            }
        }
        private void PreremplirChamps(FilmsDTO film)
        {
            txtTitre.Text = film.fi_nom;
            txtDescription.Text = film.fi_description;
            cmbGenre.SelectedItem = Convert.ToInt32(film.fi_genre);
        }

        private async Task<string> AjouterFilm(AjoutFilmsDTO Film)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Film), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7013/Admin/Films/AjoutFilm", content);

            if (response.IsSuccessStatusCode)
            {
                return string.Empty; // Opération réussie
            }
            else
            {
                // Lire le contenu de la réponse pour obtenir le message d'erreur
                var errorContent = await response.Content.ReadAsStringAsync();
                return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de l'ajout du film.";
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter sans enregistrer les modifications ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            lblAvertissement.Text = "";
            string resultMessage;
            bool isSuccess;

            if (_modeActuel == Mode.Ajout)
            {
                var filmDTO = new AjoutFilmsDTO
                {
                    fi_nom = txtTitre.Text,
                    fi_description = txtDescription.Text,
                    fi_genre = cmbGenre.SelectedItem.ToString()
                };

                resultMessage = await AjouterFilm(filmDTO);
            }
            else // Mode.Modification
            {
                //var salleDTO = new MajSalleDTO
                //{
                //    sa_id = _salleSelectionnee.sa_id,
                //    sa_numeroSalle = Convert.ToInt32(cmbNumSalle.SelectedItem),
                //    sa_qteRangees = Convert.ToInt32(cmbQteRangees.SelectedItem),
                //    sa_qtePlace = Convert.ToInt32(cmbNbrPlace.SelectedItem),
                //    sa_qtePlace_Rangee = _qtePlacesRangee,
                //    sa_ci_id = _cinemaId
                //};

                //resultMessage = await ModifierSalle(salleDTO);
                resultMessage = "";
            }

            if (string.IsNullOrEmpty(resultMessage))
            {
                MessageBox.Show("L'opération a été réalisée avec succès ! Les informations ont été mises à jour dans la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblAvertissement.Text = resultMessage; // Afficher le message d'erreur retourné par l'API
            }
        }
    }
}
