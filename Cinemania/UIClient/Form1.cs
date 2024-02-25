using Newtonsoft.Json;

namespace UIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btCine_Click(object sender, EventArgs e)
        {
            string sUrlServeur = "https://localhost:7013";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(sUrlServeur + "/api/Admin/Cinemas");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject(responseContent);
                    dgvCine.DataSource = data;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            bt1 = new Button();

            bt1.Location = new Point(100, 273);
            bt1.Name = "bt2";
            bt1.Size = new Size(30, 23);
            bt1.TabIndex = 2;
            bt1.Text = "2";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += new EventHandler(bt1_Click);

            Controls.Add(bt1);
        }
    }
}