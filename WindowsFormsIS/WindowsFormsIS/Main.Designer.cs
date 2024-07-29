namespace WindowsFormsIS
{
    partial class Main
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
            this.BtnAuthorize = new System.Windows.Forms.Button();
            this.labelToken = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.BtnAuthorizeAdmin = new System.Windows.Forms.Button();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.BtnTablesData = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnPart4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAuthorize
            // 
            this.BtnAuthorize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAuthorize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAuthorize.Location = new System.Drawing.Point(237, 452);
            this.BtnAuthorize.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAuthorize.Name = "BtnAuthorize";
            this.BtnAuthorize.Size = new System.Drawing.Size(188, 42);
            this.BtnAuthorize.TabIndex = 0;
            this.BtnAuthorize.Text = "Authorize Test";
            this.BtnAuthorize.UseVisualStyleBackColor = true;
            this.BtnAuthorize.Click += new System.EventHandler(this.BtnAuthorize_Click);
            // 
            // labelToken
            // 
            this.labelToken.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.Location = new System.Drawing.Point(5, 84);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(225, 34);
            this.labelToken.TabIndex = 1;
            this.labelToken.Text = "Your Token: ";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToken.Location = new System.Drawing.Point(10, 121);
            this.textBoxToken.Multiline = true;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(815, 121);
            this.textBoxToken.TabIndex = 2;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(319, 24);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(125, 25);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAuthorizeAdmin
            // 
            this.BtnAuthorizeAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAuthorizeAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAuthorizeAdmin.Location = new System.Drawing.Point(430, 452);
            this.BtnAuthorizeAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAuthorizeAdmin.Name = "BtnAuthorizeAdmin";
            this.BtnAuthorizeAdmin.Size = new System.Drawing.Size(200, 42);
            this.BtnAuthorizeAdmin.TabIndex = 4;
            this.BtnAuthorizeAdmin.Text = "Authorize (If Admin)";
            this.BtnAuthorizeAdmin.UseVisualStyleBackColor = true;
            this.BtnAuthorizeAdmin.Click += new System.EventHandler(this.BtnAuthorizeAdmin_Click);
            // 
            // BtnConverter
            // 
            this.BtnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConverter.Enabled = false;
            this.BtnConverter.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverter.Location = new System.Drawing.Point(9, 254);
            this.BtnConverter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(128, 28);
            this.BtnConverter.TabIndex = 5;
            this.BtnConverter.Text = "Converter Data";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTablesData
            // 
            this.BtnTablesData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTablesData.Enabled = false;
            this.BtnTablesData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablesData.Location = new System.Drawing.Point(9, 287);
            this.BtnTablesData.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTablesData.Name = "BtnTablesData";
            this.BtnTablesData.Size = new System.Drawing.Size(128, 28);
            this.BtnTablesData.TabIndex = 6;
            this.BtnTablesData.Text = "SQL Tables";
            this.BtnTablesData.UseVisualStyleBackColor = true;
            this.BtnTablesData.Click += new System.EventHandler(this.tablesData_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.IndianRed;
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(743, 11);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(79, 38);
            this.BtnLogOut.TabIndex = 7;
            this.BtnLogOut.Text = "LogOut";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnPart4
            // 
            this.BtnPart4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPart4.Enabled = false;
            this.BtnPart4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPart4.Location = new System.Drawing.Point(9, 321);
            this.BtnPart4.Name = "BtnPart4";
            this.BtnPart4.Size = new System.Drawing.Size(128, 28);
            this.BtnPart4.TabIndex = 8;
            this.BtnPart4.Text = "Part 4";
            this.BtnPart4.UseVisualStyleBackColor = true;
            this.BtnPart4.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.BtnPart4);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnTablesData);
            this.Controls.Add(this.BtnConverter);
            this.Controls.Add(this.BtnAuthorizeAdmin);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.BtnAuthorize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAuthorize;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button BtnAuthorizeAdmin;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Button BtnTablesData;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnPart4;
    }
}