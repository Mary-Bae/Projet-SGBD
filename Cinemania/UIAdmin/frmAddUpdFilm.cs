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
        private Color _defaultColor = SystemColors.GrayText;
        public frmAddUpdFilm(Mode mode, FilmsDTO? film = null)
        {
            InitializeComponent();
            _modeActuel = mode;
            _filmSelectionne = film;

            if (_modeActuel == Mode.Modification && _filmSelectionne != null)
            {
                PreremplirChamps(_filmSelectionne);
            }
            else if (_modeActuel == Mode.Ajout)
            {
                txtTitre.ForeColor = Color.Black;
            }
        }
        private void PreremplirChamps(FilmsDTO film)
        {
            txtTitre.Text = film.fi_nom;
            txtDescription.Text = film.fi_description;
            cmbGenre.SelectedItem = film.fi_genre;
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
        private async Task<string> ModifierFilm(FilmsDTO Film)
        {
            var content = new StringContent(JsonConvert.SerializeObject(Film), Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7013/Admin/Films/MajFilm/" + Film.fi_id, content);

            if (response.IsSuccessStatusCode)
            {
                return string.Empty; // Opération réussie
            }
            else
            {
                // Lire le contenu de la réponse pour obtenir le message d'erreur
                var errorContent = await response.Content.ReadAsStringAsync();
                return !string.IsNullOrWhiteSpace(errorContent) ? errorContent : "Échec de la modification du film.";
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
                if (cmbGenre.SelectedIndex == -1)
                {
                    var film = new AjoutFilmsDTO
                    {
                        fi_nom = txtTitre.Text,
                        fi_description = txtDescription.Text,
                        fi_genre = ""
                    };
                    resultMessage = await AjouterFilm(film);
                }
                else
                {
                    var film = new AjoutFilmsDTO
                    {
                        fi_nom = txtTitre.Text,
                        fi_description = txtDescription.Text,
                        fi_genre = cmbGenre.SelectedItem.ToString()
                    };
                    resultMessage = await AjouterFilm(film);
                }  
            }
            else // Mode.Modification
            {
                if (cmbGenre.SelectedIndex == -1)
                {
                    var film = new FilmsDTO
                    {
                        fi_id = _filmSelectionne.fi_id,
                        fi_nom = txtTitre.Text,
                        fi_description = txtDescription.Text,
                        fi_genre = ""
                    };
                    resultMessage = await ModifierFilm(film);
                }
                else
                {
                    var film = new FilmsDTO
                    {
                        fi_id = _filmSelectionne.fi_id,
                        fi_nom = txtTitre.Text,
                        fi_description = txtDescription.Text,
                        fi_genre = cmbGenre.SelectedItem.ToString()
                    };
                    resultMessage = await ModifierFilm(film);
                }
            }

            if (string.IsNullOrEmpty(resultMessage))
            {
                MessageBox.Show("L'opération a été réalisée avec succès ! Les informations ont été mises à jour dans la base de données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblAvertissement.Text = resultMessage;
            }
        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {
            if (_modeActuel == Mode.Modification)
            {
                if (txtTitre.Text != _filmSelectionne.fi_nom)
                    txtTitre.ForeColor = Color.Black;
                else
                    txtTitre.ForeColor = _defaultColor;
            }
            else
            {
                txtTitre.ForeColor = Color.Black;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (_modeActuel == Mode.Modification)
            {
                if (txtDescription.Text != _filmSelectionne.fi_description)
                    txtDescription.ForeColor = Color.Black;
                else
                    txtDescription.ForeColor = _defaultColor;
            }
            else
            {
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_modeActuel == Mode.Modification)
            {
                if (!cmbGenre.SelectedItem.Equals(_filmSelectionne.fi_genre))
                    cmbGenre.ForeColor = Color.Black;
                else
                    cmbGenre.ForeColor = _defaultColor;
            }
            else
            {
                cmbGenre.ForeColor = Color.Black;
            }
        }
    }
}
