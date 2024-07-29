using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsIS.Classes;

namespace WindowsFormsIS 
{
    public partial class Main : Form 
    {
        static string token;
        static string name;
        static Boolean verification;

        Converter converterPage = new Converter();
        TablesData tablesDataPage = new TablesData();
        FormUserLogin loginPage = new FormUserLogin();
        Part4 testIS = new Part4();

        public Main() 
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) 
        {
            token = Singleton.Instance.data.token;
            name = Singleton.Instance.data.name;
            verification = Singleton.Instance.data.verificaion;

            dynamic json = JsonConvert.DeserializeObject(token);
            string tokenString = json.token;

            textBoxToken.Text = tokenString;
            labelWelcome.Text += name;

            if (verification == true)
            {
                BtnConverter.Enabled = true;
                BtnTablesData.Enabled = true;
                BtnPart4.Enabled = true;
            }
        }

        private async void BtnAuthorize_Click(object sender, EventArgs e) 
        {
            try 
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => 
                {
                    return true;
                };

                var client = new HttpClient(handler);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", textBoxToken.Text);

                HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/auth/classep");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Singleton.Instance.data.verificaion = true;

                BtnConverter.Enabled = true;
                BtnTablesData.Enabled = true;
                BtnPart4.Enabled = true;

                var result = MessageBox.Show($"User Authorize!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex) 
            {
                MessageBox.Show($"Erro ao criar o post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAuthorizeAdmin_Click(object sender, EventArgs e) 
        {
            try 
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => 
                {
                    return true;
                };

                var client = new HttpClient(handler);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", textBoxToken.Text);

                HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/auth/classep0");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var result = MessageBox.Show($"Admin Authorize!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex) 
            {
                MessageBox.Show($"Erro ao criar o post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            token = "";
            name = "";
            Singleton.Instance.data.token = "";
            Singleton.Instance.data.name = "";

            this.Hide();
            loginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            converterPage.Show();
        }

        private void tablesData_Click(object sender, EventArgs e)
        {
            this.Hide();
            tablesDataPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            testIS.Show();
        }
    }
}
