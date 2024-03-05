using Models;
using Newtonsoft.Json;
using System.Text;

namespace UIAdmin
{
    public partial class frmAjoutCinema : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public int ChaineId { get; set; }
        public frmAjoutCinema()
        {
            InitializeComponent();
        }
        
        private async void btSave_Click(object sender, EventArgs e)
        {
            string nomCinema = txtNomCinema.Text;
            string adresseCinema = txtAdresseCinema.Text;

            if (string.IsNullOrWhiteSpace(nomCinema) || string.IsNullOrWhiteSpace(adresseCinema))
            {
                MessageBox.Show("Veuillez remplir tous les champs requis.");
                return;
            }

            var nouveauCinema = new MajCinemasDTO
            {
                ci_nom = txtNomCinema.Text,
                ci_adresse = txtAdresseCinema.Text,
                ci_ch_id = ChaineId
            };
            var isSuccess = await AjouterCinemaAsync(nouveauCinema);

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("La création du cinéma a échoué.");
            }
        }

        private async Task<bool> AjouterCinemaAsync(MajCinemasDTO cinema)
        {
            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(cinema), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("https://localhost:7013/Admin/Cinemas/AjoutCinemas", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}");
                return false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
        }
    }
}
