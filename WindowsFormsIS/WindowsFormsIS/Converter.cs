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
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using WindowsFormsIS.Classes;

namespace WindowsFormsIS
{
    public partial class Converter : Form
    {
        private readonly HttpClient client = new HttpClient();
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private async Task LoadDataIntoDataGridView()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/team");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(responseBody);

            //dataGridView1.DataSource = teams;
        }

        private async void BtnXmlExp_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/livro/xml");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                textBoxConverter2.Text = responseBody;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obtém o conteúdo da caixa de saída
                        string xmlContent = textBoxConverter2.Text;

                        // Escreve o conteúdo no arquivo selecionado
                        File.WriteAllText(saveFileDialog.FileName, xmlContent);

                        MessageBox.Show("Dados exportados com sucesso para o arquivo XML!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exportar os dados para o arquivo XML: " + ex.Message);
                    }

                    await LoadDataIntoDataGridView();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro de solicitação HTTP: {ex.Message}");
            }
        }

        private async void BtnXmlExpUsers_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/league/xml");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                textBoxConverter2.Text = responseBody;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obtém o conteúdo da caixa de saída
                        string xmlContent = textBoxConverter2.Text;

                        // Escreve o conteúdo no arquivo selecionado
                        File.WriteAllText(saveFileDialog.FileName, xmlContent);

                        MessageBox.Show("Dados exportados com sucesso para o arquivo XML!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exportar os dados para o arquivo XML: " + ex.Message);
                    }

                    await LoadDataIntoDataGridView();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro de solicitação HTTP: {ex.Message}");
            }
        }

        private async void BtnConverteXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false; // Altere isso para permitir apenas a seleção de um arquivo
            openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml"; // Filtre apenas arquivos XML
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialog.FileName;
                string xmlContent = File.ReadAllText(xmlFilePath);

                try
                {
                    string jsonContent = ConvertXmlToJson(xmlContent);
                    textBoxConverter2.Text = jsonContent;

                    var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/team", content);

                    MessageBox.Show("XML importado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao importar XML: {ex.Message}");
                }
            }

            await LoadDataIntoDataGridView();
        }

        private string ConvertXmlToJson(string xmlContent)
        {
            var doc = new System.Xml.XmlDocument();
            doc.LoadXml(xmlContent);

            // Inicializa um array JSON vazio para armazenar as equipas individuais
            var productsArray = new JArray();

            // Obtém todos os elementos "Produto" do XML
            var produtoNodes = doc.SelectNodes("//Team");

            // Para cada elemento "Produto" no XML, converte em um objeto JSON e adiciona ao array
            foreach (XmlNode node in produtoNodes)
            {
                var produto = new JObject();
                produto["teamName"] = node.SelectSingleNode("Nome")?.InnerText;
                produto["teamName"] = node.SelectSingleNode("Marca")?.InnerText;
                productsArray.Add(produto);
            }

            // Retorna diretamente o array de produtos como string JSON
            return productsArray.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main();
            this.Hide();
            mainPage.Show();
        }
    }
}
