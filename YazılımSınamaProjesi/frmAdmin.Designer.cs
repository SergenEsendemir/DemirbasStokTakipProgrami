namespace YazılımSınamaProjesi
{
    partial class frmAdmin
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
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStokGuncelle = new System.Windows.Forms.Button();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.btnOdaGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.FlatAppearance.BorderSize = 0;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnAdminBack.Location = new System.Drawing.Point(16, 15);
            this.btnAdminBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(45, 41);
            this.btnAdminBack.TabIndex = 1;
            this.btnAdminBack.UseVisualStyleBackColor = true;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Location = new System.Drawing.Point(16, 63);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(312, 262);
            this.btnStokEkle.TabIndex = 2;
            this.btnStokEkle.Text = "STOK EKLEME";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnStokGuncelle
            // 
            this.btnStokGuncelle.Location = new System.Drawing.Point(336, 63);
            this.btnStokGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokGuncelle.Name = "btnStokGuncelle";
            this.btnStokGuncelle.Size = new System.Drawing.Size(293, 262);
            this.btnStokGuncelle.TabIndex = 3;
            this.btnStokGuncelle.Text = "STOK GÜNCELLE";
            this.btnStokGuncelle.UseVisualStyleBackColor = true;
            this.btnStokGuncelle.Click += new System.EventHandler(this.btnStokGuncelle_Click);
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(16, 332);
            this.btnOdaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(201, 220);
            this.btnOdaEkle.TabIndex = 4;
            this.btnOdaEkle.Text = "ODA EKLE";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Location = new System.Drawing.Point(225, 332);
            this.btnOdaSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(196, 222);
            this.btnOdaSil.TabIndex = 5;
            this.btnOdaSil.Text = "ODA SİL";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.Location = new System.Drawing.Point(429, 332);
            this.btnOdaGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(200, 222);
            this.btnOdaGuncelle.TabIndex = 6;
            this.btnOdaGuncelle.Text = "ODA GÜNCELLE";
            this.btnOdaGuncelle.UseVisualStyleBackColor = true;
            this.btnOdaGuncelle.Click += new System.EventHandler(this.btnOdaGuncelle_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.ControlBox = false;
            this.Controls.Add(this.btnOdaGuncelle);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.btnStokGuncelle);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnAdminBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnStokGuncelle;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.Button btnOdaSil;
        private System.Windows.Forms.Button btnOdaGuncelle;
    }
}