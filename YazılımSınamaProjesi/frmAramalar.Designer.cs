namespace YazılımSınamaProjesi
{
    partial class frmAramalar
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
            this.gbPersonelArama = new System.Windows.Forms.GroupBox();
            this.btnAramalarArama = new System.Windows.Forms.Button();
            this.lblAramalarSoyad = new System.Windows.Forms.Label();
            this.lblAramalarAd = new System.Windows.Forms.Label();
            this.txtAramalarSoyad = new System.Windows.Forms.TextBox();
            this.txtAramalarAd = new System.Windows.Forms.TextBox();
            this.dgwAramalarPersonel = new System.Windows.Forms.DataGridView();
            this.gbDemirbasArama = new System.Windows.Forms.GroupBox();
            this.dtmBilgi = new System.Windows.Forms.DateTimePicker();
            this.btnDemirbasArama = new System.Windows.Forms.Button();
            this.rdbAdet = new System.Windows.Forms.RadioButton();
            this.rdbAlimTarihi = new System.Windows.Forms.RadioButton();
            this.rdbFiyat = new System.Windows.Forms.RadioButton();
            this.rdbDemirbasTuru = new System.Windows.Forms.RadioButton();
            this.rdbDemirbasAdi = new System.Windows.Forms.RadioButton();
            this.dgwAramalarDemirbas = new System.Windows.Forms.DataGridView();
            this.txtAramalarBilgiGiriniz = new System.Windows.Forms.TextBox();
            this.lblAramalarBilgiGiriniz = new System.Windows.Forms.Label();
            this.lblAramalarAramaTuru = new System.Windows.Forms.Label();
            this.btnAramalarBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonelArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAramalarPersonel)).BeginInit();
            this.gbDemirbasArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAramalarDemirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonelArama
            // 
            this.gbPersonelArama.Controls.Add(this.btnAramalarArama);
            this.gbPersonelArama.Controls.Add(this.lblAramalarSoyad);
            this.gbPersonelArama.Controls.Add(this.lblAramalarAd);
            this.gbPersonelArama.Controls.Add(this.txtAramalarSoyad);
            this.gbPersonelArama.Controls.Add(this.txtAramalarAd);
            this.gbPersonelArama.Controls.Add(this.dgwAramalarPersonel);
            this.gbPersonelArama.Location = new System.Drawing.Point(17, 85);
            this.gbPersonelArama.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersonelArama.Name = "gbPersonelArama";
            this.gbPersonelArama.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersonelArama.Size = new System.Drawing.Size(487, 468);
            this.gbPersonelArama.TabIndex = 1;
            this.gbPersonelArama.TabStop = false;
            this.gbPersonelArama.Text = "Personel arama";
            // 
            // btnAramalarArama
            // 
            this.btnAramalarArama.Location = new System.Drawing.Point(206, 145);
            this.btnAramalarArama.Margin = new System.Windows.Forms.Padding(4);
            this.btnAramalarArama.Name = "btnAramalarArama";
            this.btnAramalarArama.Size = new System.Drawing.Size(133, 28);
            this.btnAramalarArama.TabIndex = 5;
            this.btnAramalarArama.Text = "ARAMA";
            this.btnAramalarArama.UseVisualStyleBackColor = true;
            this.btnAramalarArama.Click += new System.EventHandler(this.btnAramalarArama_Click);
            // 
            // lblAramalarSoyad
            // 
            this.lblAramalarSoyad.AutoSize = true;
            this.lblAramalarSoyad.Location = new System.Drawing.Point(131, 93);
            this.lblAramalarSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAramalarSoyad.Name = "lblAramalarSoyad";
            this.lblAramalarSoyad.Size = new System.Drawing.Size(64, 17);
            this.lblAramalarSoyad.TabIndex = 4;
            this.lblAramalarSoyad.Text = "SOYAD :";
            // 
            // lblAramalarAd
            // 
            this.lblAramalarAd.AutoSize = true;
            this.lblAramalarAd.Location = new System.Drawing.Point(131, 49);
            this.lblAramalarAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAramalarAd.Name = "lblAramalarAd";
            this.lblAramalarAd.Size = new System.Drawing.Size(35, 17);
            this.lblAramalarAd.TabIndex = 3;
            this.lblAramalarAd.Text = "AD :";
            // 
            // txtAramalarSoyad
            // 
            this.txtAramalarSoyad.Location = new System.Drawing.Point(206, 89);
            this.txtAramalarSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAramalarSoyad.Name = "txtAramalarSoyad";
            this.txtAramalarSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtAramalarSoyad.TabIndex = 2;
            this.txtAramalarSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramalarSoyad_KeyPress);
            // 
            // txtAramalarAd
            // 
            this.txtAramalarAd.Location = new System.Drawing.Point(206, 45);
            this.txtAramalarAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAramalarAd.Name = "txtAramalarAd";
            this.txtAramalarAd.Size = new System.Drawing.Size(132, 22);
            this.txtAramalarAd.TabIndex = 1;
            this.txtAramalarAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramalarAd_KeyPress);
            // 
            // dgwAramalarPersonel
            // 
            this.dgwAramalarPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAramalarPersonel.Location = new System.Drawing.Point(-1, 197);
            this.dgwAramalarPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.dgwAramalarPersonel.Name = "dgwAramalarPersonel";
            this.dgwAramalarPersonel.ReadOnly = true;
            this.dgwAramalarPersonel.Size = new System.Drawing.Size(480, 227);
            this.dgwAramalarPersonel.TabIndex = 0;
            // 
            // gbDemirbasArama
            // 
            this.gbDemirbasArama.Controls.Add(this.dtmBilgi);
            this.gbDemirbasArama.Controls.Add(this.btnDemirbasArama);
            this.gbDemirbasArama.Controls.Add(this.rdbAdet);
            this.gbDemirbasArama.Controls.Add(this.rdbAlimTarihi);
            this.gbDemirbasArama.Controls.Add(this.rdbFiyat);
            this.gbDemirbasArama.Controls.Add(this.rdbDemirbasTuru);
            this.gbDemirbasArama.Controls.Add(this.rdbDemirbasAdi);
            this.gbDemirbasArama.Controls.Add(this.dgwAramalarDemirbas);
            this.gbDemirbasArama.Controls.Add(this.txtAramalarBilgiGiriniz);
            this.gbDemirbasArama.Controls.Add(this.lblAramalarBilgiGiriniz);
            this.gbDemirbasArama.Controls.Add(this.lblAramalarAramaTuru);
            this.gbDemirbasArama.Location = new System.Drawing.Point(522, 85);
            this.gbDemirbasArama.Margin = new System.Windows.Forms.Padding(4);
            this.gbDemirbasArama.Name = "gbDemirbasArama";
            this.gbDemirbasArama.Padding = new System.Windows.Forms.Padding(4);
            this.gbDemirbasArama.Size = new System.Drawing.Size(511, 468);
            this.gbDemirbasArama.TabIndex = 2;
            this.gbDemirbasArama.TabStop = false;
            this.gbDemirbasArama.Text = "Demirbaş  arama ";
            // 
            // dtmBilgi
            // 
            this.dtmBilgi.Location = new System.Drawing.Point(133, 139);
            this.dtmBilgi.Name = "dtmBilgi";
            this.dtmBilgi.Size = new System.Drawing.Size(161, 22);
            this.dtmBilgi.TabIndex = 12;
            // 
            // btnDemirbasArama
            // 
            this.btnDemirbasArama.Location = new System.Drawing.Point(343, 135);
            this.btnDemirbasArama.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemirbasArama.Name = "btnDemirbasArama";
            this.btnDemirbasArama.Size = new System.Drawing.Size(133, 28);
            this.btnDemirbasArama.TabIndex = 11;
            this.btnDemirbasArama.Text = "ARAMA";
            this.btnDemirbasArama.UseVisualStyleBackColor = true;
            this.btnDemirbasArama.Click += new System.EventHandler(this.btnDemirbasArama_Click);
            // 
            // rdbAdet
            // 
            this.rdbAdet.AutoSize = true;
            this.rdbAdet.Location = new System.Drawing.Point(308, 91);
            this.rdbAdet.Name = "rdbAdet";
            this.rdbAdet.Size = new System.Drawing.Size(58, 21);
            this.rdbAdet.TabIndex = 10;
            this.rdbAdet.Text = "Adet";
            this.rdbAdet.UseVisualStyleBackColor = true;
            this.rdbAdet.CheckedChanged += new System.EventHandler(this.rdbAdet_CheckedChanged);
            // 
            // rdbAlimTarihi
            // 
            this.rdbAlimTarihi.AutoSize = true;
            this.rdbAlimTarihi.Location = new System.Drawing.Point(187, 91);
            this.rdbAlimTarihi.Name = "rdbAlimTarihi";
            this.rdbAlimTarihi.Size = new System.Drawing.Size(95, 21);
            this.rdbAlimTarihi.TabIndex = 9;
            this.rdbAlimTarihi.Text = "Alım Tarihi";
            this.rdbAlimTarihi.UseVisualStyleBackColor = true;
            this.rdbAlimTarihi.CheckedChanged += new System.EventHandler(this.rdbAlimTarihi_CheckedChanged);
            // 
            // rdbFiyat
            // 
            this.rdbFiyat.AutoSize = true;
            this.rdbFiyat.Location = new System.Drawing.Point(417, 45);
            this.rdbFiyat.Name = "rdbFiyat";
            this.rdbFiyat.Size = new System.Drawing.Size(59, 21);
            this.rdbFiyat.TabIndex = 8;
            this.rdbFiyat.Text = "Fiyat";
            this.rdbFiyat.UseVisualStyleBackColor = true;
            this.rdbFiyat.CheckedChanged += new System.EventHandler(this.rdbFiyat_CheckedChanged);
            // 
            // rdbDemirbasTuru
            // 
            this.rdbDemirbasTuru.AutoSize = true;
            this.rdbDemirbasTuru.Location = new System.Drawing.Point(270, 47);
            this.rdbDemirbasTuru.Name = "rdbDemirbasTuru";
            this.rdbDemirbasTuru.Size = new System.Drawing.Size(123, 21);
            this.rdbDemirbasTuru.TabIndex = 7;
            this.rdbDemirbasTuru.Text = "Demirbaş Türü";
            this.rdbDemirbasTuru.UseVisualStyleBackColor = true;
            this.rdbDemirbasTuru.CheckedChanged += new System.EventHandler(this.rdbDemirbasTuru_CheckedChanged);
            // 
            // rdbDemirbasAdi
            // 
            this.rdbDemirbasAdi.AutoSize = true;
            this.rdbDemirbasAdi.Checked = true;
            this.rdbDemirbasAdi.Location = new System.Drawing.Point(133, 47);
            this.rdbDemirbasAdi.Name = "rdbDemirbasAdi";
            this.rdbDemirbasAdi.Size = new System.Drawing.Size(113, 21);
            this.rdbDemirbasAdi.TabIndex = 6;
            this.rdbDemirbasAdi.TabStop = true;
            this.rdbDemirbasAdi.Text = "Demirbaş Adı";
            this.rdbDemirbasAdi.UseVisualStyleBackColor = true;
            this.rdbDemirbasAdi.CheckedChanged += new System.EventHandler(this.rdbDemirbasAdi_CheckedChanged);
            // 
            // dgwAramalarDemirbas
            // 
            this.dgwAramalarDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAramalarDemirbas.Location = new System.Drawing.Point(8, 197);
            this.dgwAramalarDemirbas.Margin = new System.Windows.Forms.Padding(4);
            this.dgwAramalarDemirbas.Name = "dgwAramalarDemirbas";
            this.dgwAramalarDemirbas.ReadOnly = true;
            this.dgwAramalarDemirbas.Size = new System.Drawing.Size(495, 227);
            this.dgwAramalarDemirbas.TabIndex = 5;
            // 
            // txtAramalarBilgiGiriniz
            // 
            this.txtAramalarBilgiGiriniz.Location = new System.Drawing.Point(133, 139);
            this.txtAramalarBilgiGiriniz.Margin = new System.Windows.Forms.Padding(4);
            this.txtAramalarBilgiGiriniz.Name = "txtAramalarBilgiGiriniz";
            this.txtAramalarBilgiGiriniz.Size = new System.Drawing.Size(161, 22);
            this.txtAramalarBilgiGiriniz.TabIndex = 3;
            // 
            // lblAramalarBilgiGiriniz
            // 
            this.lblAramalarBilgiGiriniz.AutoSize = true;
            this.lblAramalarBilgiGiriniz.Location = new System.Drawing.Point(31, 141);
            this.lblAramalarBilgiGiriniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAramalarBilgiGiriniz.Name = "lblAramalarBilgiGiriniz";
            this.lblAramalarBilgiGiriniz.Size = new System.Drawing.Size(86, 17);
            this.lblAramalarBilgiGiriniz.TabIndex = 2;
            this.lblAramalarBilgiGiriniz.Text = "Bilgi Giriniz :";
            // 
            // lblAramalarAramaTuru
            // 
            this.lblAramalarAramaTuru.AutoSize = true;
            this.lblAramalarAramaTuru.Location = new System.Drawing.Point(26, 47);
            this.lblAramalarAramaTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAramalarAramaTuru.Name = "lblAramalarAramaTuru";
            this.lblAramalarAramaTuru.Size = new System.Drawing.Size(91, 17);
            this.lblAramalarAramaTuru.TabIndex = 1;
            this.lblAramalarAramaTuru.Text = "Arama Türü :";
            // 
            // btnAramalarBack
            // 
            this.btnAramalarBack.FlatAppearance.BorderSize = 0;
            this.btnAramalarBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAramalarBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnAramalarBack.Location = new System.Drawing.Point(16, 15);
            this.btnAramalarBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAramalarBack.Name = "btnAramalarBack";
            this.btnAramalarBack.Size = new System.Drawing.Size(45, 41);
            this.btnAramalarBack.TabIndex = 0;
            this.btnAramalarBack.UseVisualStyleBackColor = true;
            this.btnAramalarBack.Click += new System.EventHandler(this.btnAramalarBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAramalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 583);
            this.ControlBox = false;
            this.Controls.Add(this.gbDemirbasArama);
            this.Controls.Add(this.gbPersonelArama);
            this.Controls.Add(this.btnAramalarBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAramalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aramalar";
            this.Load += new System.EventHandler(this.frmAramalar_Load);
            this.gbPersonelArama.ResumeLayout(false);
            this.gbPersonelArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAramalarPersonel)).EndInit();
            this.gbDemirbasArama.ResumeLayout(false);
            this.gbDemirbasArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAramalarDemirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAramalarBack;
        private System.Windows.Forms.GroupBox gbPersonelArama;
        private System.Windows.Forms.Button btnAramalarArama;
        private System.Windows.Forms.Label lblAramalarSoyad;
        private System.Windows.Forms.Label lblAramalarAd;
        private System.Windows.Forms.TextBox txtAramalarSoyad;
        private System.Windows.Forms.TextBox txtAramalarAd;
        private System.Windows.Forms.DataGridView dgwAramalarPersonel;
        private System.Windows.Forms.GroupBox gbDemirbasArama;
        private System.Windows.Forms.DataGridView dgwAramalarDemirbas;
        private System.Windows.Forms.TextBox txtAramalarBilgiGiriniz;
        private System.Windows.Forms.Label lblAramalarBilgiGiriniz;
        private System.Windows.Forms.Label lblAramalarAramaTuru;
        private System.Windows.Forms.RadioButton rdbAdet;
        private System.Windows.Forms.RadioButton rdbAlimTarihi;
        private System.Windows.Forms.RadioButton rdbFiyat;
        private System.Windows.Forms.RadioButton rdbDemirbasTuru;
        private System.Windows.Forms.RadioButton rdbDemirbasAdi;
        private System.Windows.Forms.Button btnDemirbasArama;
        private System.Windows.Forms.DateTimePicker dtmBilgi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}