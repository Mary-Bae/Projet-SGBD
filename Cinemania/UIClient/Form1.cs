using Newtonsoft.Json;

namespace UIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sUrl = "https://localhost:7013/api/Admin";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(sUrl);
                if(response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject(responseContent);
                    dataGrid.DataSource = data;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                }
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.bt1 = new System.Windows.Forms.Button();

            this.bt1.Location = new System.Drawing.Point(100, 273);
            this.bt1.Name = "bt2";
            this.bt1.Size = new System.Drawing.Size(30, 23);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "2";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);

            this.Controls.Add(this.bt1);
        }
    }
}