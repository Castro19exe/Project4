namespace WindowsFormsIS
{
    partial class TablesData
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
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.dataGridViewLeagues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(9, 39);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowHeadersWidth = 51;
            this.dataGridViewTeams.RowTemplate.Height = 24;
            this.dataGridViewTeams.Size = new System.Drawing.Size(254, 454);
            this.dataGridViewTeams.TabIndex = 0;
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.Location = new System.Drawing.Point(10, 10);
            this.BtnGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(176, 24);
            this.BtnGoBack.TabIndex = 1;
            this.BtnGoBack.Text = "←  Return to Main Page";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // dataGridViewLeagues
            // 
            this.dataGridViewLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeagues.Location = new System.Drawing.Point(267, 39);
            this.dataGridViewLeagues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewLeagues.Name = "dataGridViewLeagues";
            this.dataGridViewLeagues.RowHeadersWidth = 51;
            this.dataGridViewLeagues.RowTemplate.Height = 24;
            this.dataGridViewLeagues.Size = new System.Drawing.Size(340, 454);
            this.dataGridViewLeagues.TabIndex = 2;
            // 
            // TablesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.dataGridViewLeagues);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.dataGridViewTeams);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TablesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables Data";
            this.Load += new System.EventHandler(this.TablesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeams;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.DataGridView dataGridViewLeagues;
    }
}