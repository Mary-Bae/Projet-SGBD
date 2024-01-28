using Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;

namespace UIAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void btGetCinemas_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(sUrlServeur + "/api/Admin/Cinemas" );
                
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    List<CinemasDTO> data = JsonConvert.DeserializeObject<List<CinemasDTO>>(responseContent);
                    dataGrid.DataSource = data;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }
        async private void btDelCinemas_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(sUrlServeur + "/api/Admin/Cinemas/14");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }

        async private void btUpdate_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";

            MajCinemasDTO oCinema = new MajCinemasDTO();
            oCinema.CINE_ID = 1;
            oCinema.CINE_Nom = "Kinepolis";
            oCinema.CINE_NbrSalles = 11;

            JsonContent content = JsonContent.Create(oCinema);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(sUrlServeur + "/api/Admin/Cinemas", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}