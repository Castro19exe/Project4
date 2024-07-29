using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsIS.Classes;

namespace WindowsFormsIS {
    public partial class FormUserLogin : Form {
        
        public FormUserLogin() {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e) {
            try {
                var post = new {
                    name = textBoxName.Text,
                    password = textBoxPassword.Text
                };

                var json = JsonSerializer.Serialize(post);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => {
                    return true;
                };

                var client = new HttpClient(handler);

                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/auth/login", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Singleton.Instance.data.token = responseBody;
                Singleton.Instance.data.name = post.name;

                var result = MessageBox.Show($".Resposta do servidor: {responseBody} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK) {
                    Main mainPage = new Main();
                    mainPage.Show();
                    this.Hide();
                }
            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Erro ao criar o post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserRegister pageRegister = new FormUserRegister();

            this.Hide();
            pageRegister.Show();
        }
    }
}
