namespace YazılımSınamaProjesi
{
    partial class frmOdaGuncelle
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
            this.txtOdaESGyeniOdaAdi = new System.Windows.Forms.TextBox();
            this.lblOdaESGyeniOdaAdi = new System.Windows.Forms.Label();
            this.lblOdaESGodaAdi2 = new System.Windows.Forms.Label();
            this.btnOdaESGguncelle = new System.Windows.Forms.Button();
            this.gbOdaGuncelleme = new System.Windows.Forms.GroupBox();
            this.cboOdaESGodaAdiGuncel = new System.Windows.Forms.ComboBox();
            this.btnOdaEkleSilBack = new System.Windows.Forms.Button();
            this.gbOdaGuncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOdaESGyeniOdaAdi
            // 
            this.txtOdaESGyeniOdaAdi.Location = new System.Drawing.Point(484, 38);
            this.txtOdaESGyeniOdaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdaESGyeniOdaAdi.Name = "txtOdaESGyeniOdaAdi";
            this.txtOdaESGyeniOdaAdi.Size = new System.Drawing.Size(132, 22);
            this.txtOdaESGyeniOdaAdi.TabIndex = 21;
            // 
            // lblOdaESGyeniOdaAdi
            // 
            this.lblOdaESGyeniOdaAdi.AutoSize = true;
            this.lblOdaESGyeniOdaAdi.Location = new System.Drawing.Point(369, 41);
            this.lblOdaESGyeniOdaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaESGyeniOdaAdi.Name = "lblOdaESGyeniOdaAdi";
            this.lblOdaESGyeniOdaAdi.Size = new System.Drawing.Size(107, 17);
            this.lblOdaESGyeniOdaAdi.TabIndex = 20;
            this.lblOdaESGyeniOdaAdi.Text = "YENİ ODA ADI :";
            // 
            // lblOdaESGodaAdi2
            // 
            this.lblOdaESGodaAdi2.AutoSize = true;
            this.lblOdaESGodaAdi2.Location = new System.Drawing.Point(8, 41);
            this.lblOdaESGodaAdi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaESGodaAdi2.Name = "lblOdaESGodaAdi2";
            this.lblOdaESGodaAdi2.Size = new System.Drawing.Size(72, 17);
            this.lblOdaESGodaAdi2.TabIndex = 22;
            this.lblOdaESGodaAdi2.Text = "ODA ADI :";
            // 
            // btnOdaESGguncelle
            // 
            this.btnOdaESGguncelle.Location = new System.Drawing.Point(524, 102);
            this.btnOdaESGguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaESGguncelle.Name = "btnOdaESGguncelle";
            this.btnOdaESGguncelle.Size = new System.Drawing.Size(100, 28);
            this.btnOdaESGguncelle.TabIndex = 24;
            this.btnOdaESGguncelle.Text = "GÜNCELLE";
            this.btnOdaESGguncelle.UseVisualStyleBackColor = true;
            this.btnOdaESGguncelle.Click += new System.EventHandler(this.btnOdaESGguncelle_Click);
            // 
            // gbOdaGuncelleme
            // 
            this.gbOdaGuncelleme.Controls.Add(this.cboOdaESGodaAdiGuncel);
            this.gbOdaGuncelleme.Controls.Add(this.txtOdaESGyeniOdaAdi);
            this.gbOdaGuncelleme.Controls.Add(this.lblOdaESGyeniOdaAdi);
            this.gbOdaGuncelleme.Controls.Add(this.btnOdaESGguncelle);
            this.gbOdaGuncelleme.Controls.Add(this.lblOdaESGodaAdi2);
            this.gbOdaGuncelleme.Location = new System.Drawing.Point(27, 94);
            this.gbOdaGuncelleme.Margin = new System.Windows.Forms.Padding(4);
            this.gbOdaGuncelleme.Name = "gbOdaGuncelleme";
            this.gbOdaGuncelleme.Padding = new System.Windows.Forms.Padding(4);
            this.gbOdaGuncelleme.Size = new System.Drawing.Size(624, 138);
            this.gbOdaGuncelleme.TabIndex = 26;
            this.gbOdaGuncelleme.TabStop = false;
            this.gbOdaGuncelleme.Text = "ODA GÜNCELLEME";
            // 
            // cboOdaESGodaAdiGuncel
            // 
            this.cboOdaESGodaAdiGuncel.FormattingEnabled = true;
            this.cboOdaESGodaAdiGuncel.Location = new System.Drawing.Point(92, 37);
            this.cboOdaESGodaAdiGuncel.Margin = new System.Windows.Forms.Padding(4);
            this.cboOdaESGodaAdiGuncel.Name = "cboOdaESGodaAdiGuncel";
            this.cboOdaESGodaAdiGuncel.Size = new System.Drawing.Size(216, 24);
            this.cboOdaESGodaAdiGuncel.TabIndex = 25;
            // 
            // btnOdaEkleSilBack
            // 
            this.btnOdaEkleSilBack.FlatAppearance.BorderSize = 0;
            this.btnOdaEkleSilBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaEkleSilBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnOdaEkleSilBack.Location = new System.Drawing.Point(16, 15);
            this.btnOdaEkleSilBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaEkleSilBack.Name = "btnOdaEkleSilBack";
            this.btnOdaEkleSilBack.Size = new System.Drawing.Size(45, 41);
            this.btnOdaEkleSilBack.TabIndex = 2;
            this.btnOdaEkleSilBack.UseVisualStyleBackColor = true;
            this.btnOdaEkleSilBack.Click += new System.EventHandler(this.btnOdaEkleSilBack_Click);
            // 
            // frmOdaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 293);
            this.ControlBox = false;
            this.Controls.Add(this.gbOdaGuncelleme);
            this.Controls.Add(this.btnOdaEkleSilBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Sil";
            this.Load += new System.EventHandler(this.frmOdaGuncelle_Load);
            this.gbOdaGuncelleme.ResumeLayout(false);
            this.gbOdaGuncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkleSilBack;
        private System.Windows.Forms.TextBox txtOdaESGyeniOdaAdi;
        private System.Windows.Forms.Label lblOdaESGyeniOdaAdi;
        private System.Windows.Forms.Label lblOdaESGodaAdi2;
        private System.Windows.Forms.Button btnOdaESGguncelle;
        private System.Windows.Forms.GroupBox gbOdaGuncelleme;
        private System.Windows.Forms.ComboBox cboOdaESGodaAdiGuncel;
    }
}