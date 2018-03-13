namespace YazılımSınamaProjesi
{
    partial class GİRİŞ_EKRANI
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
            this.components = new System.ComponentModel.Container();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbGirisEkraniPass = new System.Windows.Forms.PictureBox();
            this.pbGirisEkraniUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisEkraniPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisEkraniUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.Location = new System.Drawing.Point(124, 294);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(371, 70);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(164, 138);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(329, 36);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "KULLANICI ADI";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 197);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(329, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "ŞİFRE";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbGirisEkraniPass
            // 
            this.pbGirisEkraniPass.Image = global::YazılımSınamaProjesi.Properties.Resources.pass;
            this.pbGirisEkraniPass.Location = new System.Drawing.Point(124, 197);
            this.pbGirisEkraniPass.Margin = new System.Windows.Forms.Padding(4);
            this.pbGirisEkraniPass.Name = "pbGirisEkraniPass";
            this.pbGirisEkraniPass.Size = new System.Drawing.Size(40, 37);
            this.pbGirisEkraniPass.TabIndex = 4;
            this.pbGirisEkraniPass.TabStop = false;
            // 
            // pbGirisEkraniUser
            // 
            this.pbGirisEkraniUser.Image = global::YazılımSınamaProjesi.Properties.Resources._74472;
            this.pbGirisEkraniUser.Location = new System.Drawing.Point(124, 138);
            this.pbGirisEkraniUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbGirisEkraniUser.Name = "pbGirisEkraniUser";
            this.pbGirisEkraniUser.Size = new System.Drawing.Size(40, 37);
            this.pbGirisEkraniUser.TabIndex = 3;
            this.pbGirisEkraniUser.TabStop = false;
            // 
            // GİRİŞ_EKRANI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.pbGirisEkraniPass);
            this.Controls.Add(this.pbGirisEkraniUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnGiris);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GİRİŞ_EKRANI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisEkraniPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisEkraniUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbGirisEkraniUser;
        private System.Windows.Forms.PictureBox pbGirisEkraniPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

