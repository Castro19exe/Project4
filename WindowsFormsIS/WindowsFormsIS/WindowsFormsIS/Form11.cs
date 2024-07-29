using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsIS {

    public partial class MainForm : Form
    {
        protected object outputTextBox;

        public MainForm() { InitializeComponent(); }



        protected void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv|Arquivos XML (*.xml)|*.xml|Arquivos JSON (*.json)|*.json";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                string inputData = File.ReadAllText(filePath);

                if (fileExtension == ".csv")
                {
                    outputTextBox = ConvertCsvToJson(inputData).ToString();
                }
                else if (fileExtension == ".xml")
                {
                    outputTextBox = ConvertXmlToJson(inputData).ToString();
                }
                else if (fileExtension == ".json")
                {
                    outputTextBox = ConvertJsonToCsv(inputData);
                }
                else
                {
                    outputTextBox = "Formato de arquivo não suportado.";
                }
            }
        }

        protected JArray ConvertCsvToJson(string csvData)
        {
            JArray jsonArray = new JArray();
            string[] lines = csvData.Split('\n');
            string[] headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                JObject obj = new JObject();
                for (int j = 0; j < headers.Length; j++)
                {
                    obj.Add(headers[j], values[j]);
                }
                jsonArray.Add(obj);
            }

            return jsonArray;
        }

        protected JObject ConvertXmlToJson(string xmlData)
        {
            JObject jsonObj = JObject.Parse(JsonConvert.SerializeXmlNode(JsonConvert.DeserializeXmlNode(xmlData, "root")));
            return jsonObj;
        }

        protected string ConvertJsonToCsv(string jsonData)
        {
            JArray jsonArray = JArray.Parse(jsonData);
            StringWriter csvWriter = new StringWriter();

            JObject firstObj = (JObject)jsonArray[0];
            foreach (var property in firstObj.Properties())
            {
                csvWriter.Write(property.Name + ",");
            }
            csvWriter.WriteLine();

            foreach (JObject obj in jsonArray)
            {
                foreach (var property in obj.Properties())
                {
                    csvWriter.Write(property.Value + ",");
                }
                csvWriter.WriteLine();
            }

            return csvWriter.ToString();
        }

        protected void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(363, 160);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(141, 23);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Importar Ficheiros\r\n";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.Location = new System.Drawing.Point(58, 160);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(141, 23);
            this.botao2.TabIndex = 1;
            this.botao2.Text = "Traduzir\r\n";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "CSV";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(90, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "XML";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(90, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "JSON";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(397, 71);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(47, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "CSV";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(397, 94);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "XML";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(397, 117);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(54, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "JSON";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tecnologia de Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tecnologia de Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 100);
            this.textBox1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(677, 345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button botao1;
        private Button botao2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;

        private void botao1_Click(object sender, EventArgs e)
        {
            // Botão de Importar

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv|Arquivos XML (*.xml)|*.xml|Arquivos JSON (*.json)|*.json";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                string inputData = File.ReadAllText(filePath);

                if (fileExtension == ".csv")
                {
                    textBox1.Text = ConvertCsvToJson(inputData).ToString();
                }
                else if (fileExtension == ".xml")
                {
                    textBox1.Text = ConvertXmlToJson(inputData).ToString();
                }
                else if (fileExtension == ".json")
                {
                    textBox1.Text = ConvertJsonToCsv(inputData);
                }
                else
                {
                    textBox1.Text = "Formato de arquivo não suportado.";
                }
            }
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            // Botão de Traduzir

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                string inputFileContent = ""; // Conteúdo do arquivo selecionado
                string outputFileContent = ""; // Conteúdo do arquivo traduzido

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos CSV (*.csv)|*.csv|Arquivos XML (*.xml)|*.xml|Arquivos JSON (*.json)|*.json";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    inputFileContent = File.ReadAllText(filePath);
                }
                else
                {
                    MessageBox.Show("Nenhum arquivo selecionado.");
                    return;
                }

                if (checkBox1.Checked)
                {
                    outputFileContent = ConvertCsvToJson(inputFileContent).ToString();
                }
                else if (checkBox2.Checked)
                {
                    outputFileContent = ConvertXmlToJson(inputFileContent).ToString();
                }
                else if (checkBox3.Checked)
                {
                    outputFileContent = ConvertJsonToCsv(inputFileContent);
                }

                textBox1.Text = outputFileContent;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um formato de arquivo.");
            }
        }
    }
}
