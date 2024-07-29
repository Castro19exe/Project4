namespace WindowsFormsIS
{
    partial class Part4
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
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnection.Location = new System.Drawing.Point(44, 133);
            this.textBoxConnection.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(192, 27);
            this.textBoxConnection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(45, 93);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(191, 36);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Turn ON";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Received";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.Location = new System.Drawing.Point(292, 467);
            this.BtnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(268, 26);
            this.BtnGoBack.TabIndex = 11;
            this.BtnGoBack.Text = "←  Return to Main Page";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(590, 93);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(191, 36);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(590, 133);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(191, 270);
            this.textBoxSend.TabIndex = 13;
            // 
            // Part4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 503);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Part4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxSend;
    }
}