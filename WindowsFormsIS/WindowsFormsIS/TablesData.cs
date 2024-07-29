using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsIS.Classes;

namespace WindowsFormsIS
{
    public partial class TablesData : Form
    {
        private readonly HttpClient client = new HttpClient();

        public TablesData()
        {
            InitializeComponent();
        }

        private async Task LoadDataIntoDataGridView()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/team");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(responseBody);

            dataGridViewTeams.DataSource = teams;
        }

        private async Task LoadDataIntoDataGridViewLeagues()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/league");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<League> leagues = JsonConvert.DeserializeObject<List<League>>(responseBody);

            dataGridViewLeagues.DataSource = leagues;
        }

        private void TablesData_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            LoadDataIntoDataGridViewLeagues();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main();
            this.Hide();
            mainPage.Show();
        }
    }
}
