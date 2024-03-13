using Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace UIAdmin
{
    public partial class frmUpdateCinema : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public MajCinemasDTO Cinema { get; set; }
        public frmUpdateCinema(MajCinemasDTO cinema)
        {
            InitializeComponent();
            Cinema = cinema;
            txtNomCinema.Text = cinema.ci_nom; // Préremplir le nom du cinéma
            txtAdresseCinema.Text = cinema.ci_adresse; // Préremplir l'adresse du cinéma
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs modifiées
            Cinema.ci_nom = txtNomCinema.Text;
            Cinema.ci_adresse = txtAdresseCinema.Text;

            JsonContent content = JsonContent.Create(Cinema);
            HttpResponseMessage response = await client.PutAsync("https://localhost:7013/Admin/Cinemas/MajCinemas/" + Cinema.ci_id, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Le cinéma a été mis à jour avec succès.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("La mise à jour du cinéma a échoué. Détails : " + responseContent);
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
