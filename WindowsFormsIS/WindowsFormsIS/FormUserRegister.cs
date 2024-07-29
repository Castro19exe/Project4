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

namespace WindowsFormsIS 
{
    public partial class FormUserRegister : Form 
    {
        public FormUserRegister() 
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            FormUserLogin login = new FormUserLogin();

            this.Close();
            login.Show();
        }

        private async void BtnRegister_Click(object sender, EventArgs e) 
        {
            try 
            {
                var post = new 
                {
                    name = textBoxRegisterName.Text,
                    password = textBoxRegisterPassword.Text
                };

                var json = JsonSerializer.Serialize(post);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => {
                    return true;
                };

                var client = new HttpClient(handler);

                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/auth/register", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var result = MessageBox.Show($"User registed with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException ex) {
                MessageBox.Show($"Error, something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
