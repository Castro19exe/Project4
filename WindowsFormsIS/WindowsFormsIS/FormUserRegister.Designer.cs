namespace WindowsFormsIS
{
    partial class FormUserRegister
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
            this.linkLoginUser = new System.Windows.Forms.LinkLabel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLoginUser
            // 
            this.linkLoginUser.AutoSize = true;
            this.linkLoginUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLoginUser.Location = new System.Drawing.Point(149, 342);
            this.linkLoginUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLoginUser.Name = "linkLoginUser";
            this.linkLoginUser.Size = new System.Drawing.Size(45, 19);
            this.linkLoginUser.TabIndex = 37;
            this.linkLoginUser.TabStop = true;
            this.linkLoginUser.Text = "Login";
            this.linkLoginUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(147, 268);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(249, 54);
            this.BtnRegister.TabIndex = 32;
            this.BtnRegister.Text = "REGISTER";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(147, 203);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(249, 31);
            this.textBoxRegisterPassword.TabIndex = 41;
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterName.Location = new System.Drawing.Point(147, 121);
            this.textBoxRegisterName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegisterName.Name = "textBoxRegisterName";
            this.textBoxRegisterName.Size = new System.Drawing.Size(249, 31);
            this.textBoxRegisterName.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Register User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegisterPassword);
            this.Controls.Add(this.textBoxRegisterName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLoginUser);
            this.Controls.Add(this.BtnRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLoginUser;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}