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
        private Color _defaultColor = SystemColors.GrayText;
        public frmUpdateCinema(MajCinemasDTO cinema)
        {
            InitializeComponent();
            Cinema = cinema;
            txtNomCinema.Text = cinema.ci_nom;
            txtAdresseCinema.Text = cinema.ci_adresse;
        }
        private void txtNomCinema_TextChanged(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            if (txtNomCinema.Text != Cinema.ci_nom)
                txtNomCinema.ForeColor = Color.Black;
            else
                txtNomCinema.ForeColor = _defaultColor;
        }
        private void txtAdresseCinema_TextChanged(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            if (txtAdresseCinema.Text != Cinema.ci_adresse)
                txtAdresseCinema.ForeColor = Color.Black;
            else
                txtAdresseCinema.ForeColor = _defaultColor;
        }
        private async void btSave_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            // Récupérer les valeurs modifiées
            Cinema.ci_nom = txtNomCinema.Text;
            Cinema.ci_adresse = txtAdresseCinema.Text;

            try
            {
             JsonContent content = JsonContent.Create(Cinema);
             HttpResponseMessage response = await client.PutAsync("https://localhost:7013/Admin/Cinemas/MajCinemas/" + Cinema.ci_id, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Le cinéma a été mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    lblErreur.Text = responseContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur inattendue est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
