namespace WindowsFormsIS
{
    partial class Converter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConverter1 = new System.Windows.Forms.TextBox();
            this.textBoxConverter2 = new System.Windows.Forms.TextBox();
            this.BtnConverteXML = new System.Windows.Forms.Button();
            this.BtnConverteJSON = new System.Windows.Forms.Button();
            this.BtnConverteCSV = new System.Windows.Forms.Button();
            this.BtnXmlExp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnXmlExpLeagues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConverter1
            // 
            this.textBoxConverter1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConverter1.Location = new System.Drawing.Point(9, 10);
            this.textBoxConverter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConverter1.Multiline = true;
            this.textBoxConverter1.Name = "textBoxConverter1";
            this.textBoxConverter1.Size = new System.Drawing.Size(270, 482);
            this.textBoxConverter1.TabIndex = 0;
            // 
            // textBoxConverter2
            // 
            this.textBoxConverter2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConverter2.Location = new System.Drawing.Point(555, 10);
            this.textBoxConverter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxConverter2.Multiline = true;
            this.textBoxConverter2.Name = "textBoxConverter2";
            this.textBoxConverter2.Size = new System.Drawing.Size(270, 482);
            this.textBoxConverter2.TabIndex = 1;
            // 
            // BtnConverteXML
            // 
            this.BtnConverteXML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverteXML.Location = new System.Drawing.Point(349, 271);
            this.BtnConverteXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConverteXML.Name = "BtnConverteXML";
            this.BtnConverteXML.Size = new System.Drawing.Size(145, 49);
            this.BtnConverteXML.TabIndex = 2;
            this.BtnConverteXML.Text = "XML";
            this.BtnConverteXML.UseVisualStyleBackColor = true;
            this.BtnConverteXML.Click += new System.EventHandler(this.BtnConverteXML_Click);
            // 
            // BtnConverteJSON
            // 
            this.BtnConverteJSON.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverteJSON.Location = new System.Drawing.Point(349, 325);
            this.BtnConverteJSON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConverteJSON.Name = "BtnConverteJSON";
            this.BtnConverteJSON.Size = new System.Drawing.Size(145, 49);
            this.BtnConverteJSON.TabIndex = 3;
            this.BtnConverteJSON.Text = "JSON";
            this.BtnConverteJSON.UseVisualStyleBackColor = true;
            // 
            // BtnConverteCSV
            // 
            this.BtnConverteCSV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverteCSV.Location = new System.Drawing.Point(349, 379);
            this.BtnConverteCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConverteCSV.Name = "BtnConverteCSV";
            this.BtnConverteCSV.Size = new System.Drawing.Size(145, 49);
            this.BtnConverteCSV.TabIndex = 4;
            this.BtnConverteCSV.Text = "CSV";
            this.BtnConverteCSV.UseVisualStyleBackColor = true;
            // 
            // BtnXmlExp
            // 
            this.BtnXmlExp.Location = new System.Drawing.Point(349, 10);
            this.BtnXmlExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnXmlExp.Name = "BtnXmlExp";
            this.BtnXmlExp.Size = new System.Drawing.Size(145, 49);
            this.BtnXmlExp.TabIndex = 5;
            this.BtnXmlExp.Text = "XML Export";
            this.BtnXmlExp.UseVisualStyleBackColor = true;
            this.BtnXmlExp.Click += new System.EventHandler(this.BtnXmlExp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "←  Return to Main Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnXmlExpLeagues
            // 
            this.BtnXmlExpLeagues.Location = new System.Drawing.Point(349, 63);
            this.BtnXmlExpLeagues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnXmlExpLeagues.Name = "BtnXmlExpLeagues";
            this.BtnXmlExpLeagues.Size = new System.Drawing.Size(145, 49);
            this.BtnXmlExpLeagues.TabIndex = 7;
            this.BtnXmlExpLeagues.Text = "XML Export - Leagues";
            this.BtnXmlExpLeagues.UseVisualStyleBackColor = true;
            this.BtnXmlExpLeagues.Click += new System.EventHandler(this.BtnXmlExpUsers_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.BtnXmlExpLeagues);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnXmlExp);
            this.Controls.Add(this.BtnConverteCSV);
            this.Controls.Add(this.BtnConverteJSON);
            this.Controls.Add(this.BtnConverteXML);
            this.Controls.Add(this.textBoxConverter2);
            this.Controls.Add(this.textBoxConverter1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConverter1;
        private System.Windows.Forms.TextBox textBoxConverter2;
        private System.Windows.Forms.Button BtnConverteXML;
        private System.Windows.Forms.Button BtnConverteJSON;
        private System.Windows.Forms.Button BtnConverteCSV;
        private System.Windows.Forms.Button BtnXmlExp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnXmlExpLeagues;
    }
}