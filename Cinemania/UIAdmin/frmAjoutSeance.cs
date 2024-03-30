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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIAdmin
{
    public partial class frmAjoutSeance : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public frmAjoutSeance()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7013/Admin/ProgrammationTraduite");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    List<ListProgrammationTraduitesDTO> traductions = JsonConvert.DeserializeObject<List<ListProgrammationTraduitesDTO>>(responseData);

                    foreach (var traduction in traductions)
                    {
                        var item = new ListViewItem(new[] {
                    traduction.ci_Nom,
                    traduction.fi_Nom,
                    traduction.la_langue,
                    traduction.la_sousTitre,
                    traduction.pr_date.ToString("yyyy-MM-dd")
                });
                        item.Tag = traduction.pt_id;
                        lstProgrTrad.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de la récupération des données de programmation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void lstProgrTrad_Resize(object sender, EventArgs e)
        {
            if (lstProgrTrad.Columns.Count > 0)
            {
                int totalWidth = lstProgrTrad.Width - SystemInformation.VerticalScrollBarWidth; // Prendre en compte la largeur de la barre de défilement
                int numColumns = lstProgrTrad.Columns.Count;
                int widthPerColumn = totalWidth / numColumns;

                foreach (ColumnHeader column in lstProgrTrad.Columns)
                {
                    column.Width = widthPerColumn;
                }
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter la fenêtre d'ajout de séances ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (lstProgrTrad.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstProgrTrad.SelectedItems[0];
                int programmationTraduiteId = (int)selectedItem.Tag; // Pour récupérer l'ID à partir de la propriété Tag
                string horaire = cmbHoraire.SelectedItem.ToString();
                DateTime dateFin = calDateFin.SelectionStart;

                var seanceData = new AddSeanceDTO
                {
                    se_pt_id = programmationTraduiteId,
                    se_horaire = horaire,
                    se_dateFin = dateFin
                };

                var content = new StringContent(JsonConvert.SerializeObject(seanceData), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7013/Admin/Seance/AddSeance", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Séance ajoutée avec succès");
                    // Optionnel : rafraîchir les données affichées
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la séance");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une programmation traduite");
            }
        }

        private void calDateFin_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calDateFin.SelectionStart;
        }
    }
    }

