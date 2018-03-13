namespace YazılımSınamaProjesi
{
    partial class frmStokGuncelleme
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
            this.btnStokGuncellemeBack = new System.Windows.Forms.Button();
            this.txtSGadet = new System.Windows.Forms.TextBox();
            this.txtSGfiyat = new System.Windows.Forms.TextBox();
            this.txtSGdemirbasAdi = new System.Windows.Forms.TextBox();
            this.lblSGadet = new System.Windows.Forms.Label();
            this.btnSGguncelle = new System.Windows.Forms.Button();
            this.lblSGalimTarihi = new System.Windows.Forms.Label();
            this.lblSGfiyat = new System.Windows.Forms.Label();
            this.lblSGdemirbasTuru = new System.Windows.Forms.Label();
            this.lblSGdemirbasAdi = new System.Windows.Forms.Label();
            this.DGWStokGuncelleme = new System.Windows.Forms.DataGridView();
            this.DtmSGAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSGDemirbasTuruID = new System.Windows.Forms.TextBox();
            this.lboxSGDemirbasTuruID = new System.Windows.Forms.ListBox();
            this.lboxSGDemirbasTuruAdi = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGWStokGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokGuncellemeBack
            // 
            this.btnStokGuncellemeBack.FlatAppearance.BorderSize = 0;
            this.btnStokGuncellemeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokGuncellemeBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnStokGuncellemeBack.Location = new System.Drawing.Point(16, 15);
            this.btnStokGuncellemeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokGuncellemeBack.Name = "btnStokGuncellemeBack";
            this.btnStokGuncellemeBack.Size = new System.Drawing.Size(45, 41);
            this.btnStokGuncellemeBack.TabIndex = 2;
            this.btnStokGuncellemeBack.UseVisualStyleBackColor = true;
            this.btnStokGuncellemeBack.Click += new System.EventHandler(this.btnStokGuncellemeBack_Click);
            // 
            // txtSGadet
            // 
            this.txtSGadet.Location = new System.Drawing.Point(190, 468);
            this.txtSGadet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGadet.Name = "txtSGadet";
            this.txtSGadet.Size = new System.Drawing.Size(132, 22);
            this.txtSGadet.TabIndex = 34;
            this.txtSGadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSGadet_KeyPress);
            // 
            // txtSGfiyat
            // 
            this.txtSGfiyat.Location = new System.Drawing.Point(190, 348);
            this.txtSGfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGfiyat.Name = "txtSGfiyat";
            this.txtSGfiyat.Size = new System.Drawing.Size(132, 22);
            this.txtSGfiyat.TabIndex = 33;
            this.txtSGfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSGfiyat_KeyPress);
            // 
            // txtSGdemirbasAdi
            // 
            this.txtSGdemirbasAdi.Location = new System.Drawing.Point(190, 292);
            this.txtSGdemirbasAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGdemirbasAdi.Name = "txtSGdemirbasAdi";
            this.txtSGdemirbasAdi.Size = new System.Drawing.Size(132, 22);
            this.txtSGdemirbasAdi.TabIndex = 30;
            this.txtSGdemirbasAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSGdemirbasAdi_KeyPress);
            // 
            // lblSGadet
            // 
            this.lblSGadet.AutoSize = true;
            this.lblSGadet.Location = new System.Drawing.Point(62, 471);
            this.lblSGadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSGadet.Name = "lblSGadet";
            this.lblSGadet.Size = new System.Drawing.Size(45, 17);
            this.lblSGadet.TabIndex = 29;
            this.lblSGadet.Text = "ADET";
            // 
            // btnSGguncelle
            // 
            this.btnSGguncelle.Location = new System.Drawing.Point(65, 582);
            this.btnSGguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSGguncelle.Name = "btnSGguncelle";
            this.btnSGguncelle.Size = new System.Drawing.Size(571, 70);
            this.btnSGguncelle.TabIndex = 25;
            this.btnSGguncelle.Text = "GÜNCELLE";
            this.btnSGguncelle.UseVisualStyleBackColor = true;
            this.btnSGguncelle.Click += new System.EventHandler(this.btnSGguncelle_Click);
            // 
            // lblSGalimTarihi
            // 
            this.lblSGalimTarihi.AutoSize = true;
            this.lblSGalimTarihi.Location = new System.Drawing.Point(62, 414);
            this.lblSGalimTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSGalimTarihi.Name = "lblSGalimTarihi";
            this.lblSGalimTarihi.Size = new System.Drawing.Size(95, 17);
            this.lblSGalimTarihi.TabIndex = 23;
            this.lblSGalimTarihi.Text = "ALIM TARİHİ :";
            // 
            // lblSGfiyat
            // 
            this.lblSGfiyat.AutoSize = true;
            this.lblSGfiyat.Location = new System.Drawing.Point(62, 352);
            this.lblSGfiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSGfiyat.Name = "lblSGfiyat";
            this.lblSGfiyat.Size = new System.Drawing.Size(54, 17);
            this.lblSGfiyat.TabIndex = 22;
            this.lblSGfiyat.Text = "FİYAT :";
            // 
            // lblSGdemirbasTuru
            // 
            this.lblSGdemirbasTuru.AutoSize = true;
            this.lblSGdemirbasTuru.Location = new System.Drawing.Point(32, 522);
            this.lblSGdemirbasTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSGdemirbasTuru.Name = "lblSGdemirbasTuru";
            this.lblSGdemirbasTuru.Size = new System.Drawing.Size(142, 17);
            this.lblSGdemirbasTuru.TabIndex = 21;
            this.lblSGdemirbasTuru.Text = "DEMİRBAŞ TÜRÜ ID:";
            // 
            // lblSGdemirbasAdi
            // 
            this.lblSGdemirbasAdi.AutoSize = true;
            this.lblSGdemirbasAdi.Location = new System.Drawing.Point(62, 295);
            this.lblSGdemirbasAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSGdemirbasAdi.Name = "lblSGdemirbasAdi";
            this.lblSGdemirbasAdi.Size = new System.Drawing.Size(112, 17);
            this.lblSGdemirbasAdi.TabIndex = 20;
            this.lblSGdemirbasAdi.Text = "DEMİRBAŞ ADI :";
            // 
            // DGWStokGuncelleme
            // 
            this.DGWStokGuncelleme.AllowUserToAddRows = false;
            this.DGWStokGuncelleme.AllowUserToDeleteRows = false;
            this.DGWStokGuncelleme.AllowUserToResizeColumns = false;
            this.DGWStokGuncelleme.AllowUserToResizeRows = false;
            this.DGWStokGuncelleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWStokGuncelleme.Location = new System.Drawing.Point(78, 39);
            this.DGWStokGuncelleme.Name = "DGWStokGuncelleme";
            this.DGWStokGuncelleme.ReadOnly = true;
            this.DGWStokGuncelleme.RowTemplate.Height = 24;
            this.DGWStokGuncelleme.Size = new System.Drawing.Size(626, 227);
            this.DGWStokGuncelleme.TabIndex = 38;
            this.DGWStokGuncelleme.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWStokGuncelleme_RowEnter);
            // 
            // DtmSGAlimTarihi
            // 
            this.DtmSGAlimTarihi.Location = new System.Drawing.Point(164, 409);
            this.DtmSGAlimTarihi.Name = "DtmSGAlimTarihi";
            this.DtmSGAlimTarihi.Size = new System.Drawing.Size(200, 22);
            this.DtmSGAlimTarihi.TabIndex = 39;
            // 
            // txtSGDemirbasTuruID
            // 
            this.txtSGDemirbasTuruID.Enabled = false;
            this.txtSGDemirbasTuruID.Location = new System.Drawing.Point(190, 519);
            this.txtSGDemirbasTuruID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGDemirbasTuruID.Name = "txtSGDemirbasTuruID";
            this.txtSGDemirbasTuruID.Size = new System.Drawing.Size(132, 22);
            this.txtSGDemirbasTuruID.TabIndex = 35;
            // 
            // lboxSGDemirbasTuruID
            // 
            this.lboxSGDemirbasTuruID.FormattingEnabled = true;
            this.lboxSGDemirbasTuruID.ItemHeight = 16;
            this.lboxSGDemirbasTuruID.Location = new System.Drawing.Point(370, 348);
            this.lboxSGDemirbasTuruID.Name = "lboxSGDemirbasTuruID";
            this.lboxSGDemirbasTuruID.Size = new System.Drawing.Size(119, 164);
            this.lboxSGDemirbasTuruID.TabIndex = 36;
            this.lboxSGDemirbasTuruID.SelectedIndexChanged += new System.EventHandler(this.lboxSGDemirbasTuruID_SelectedIndexChanged);
            // 
            // lboxSGDemirbasTuruAdi
            // 
            this.lboxSGDemirbasTuruAdi.Enabled = false;
            this.lboxSGDemirbasTuruAdi.FormattingEnabled = true;
            this.lboxSGDemirbasTuruAdi.ItemHeight = 16;
            this.lboxSGDemirbasTuruAdi.Location = new System.Drawing.Point(508, 350);
            this.lboxSGDemirbasTuruAdi.Name = "lboxSGDemirbasTuruAdi";
            this.lboxSGDemirbasTuruAdi.Size = new System.Drawing.Size(119, 164);
            this.lboxSGDemirbasTuruAdi.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStokGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.DtmSGAlimTarihi);
            this.Controls.Add(this.DGWStokGuncelleme);
            this.Controls.Add(this.lboxSGDemirbasTuruAdi);
            this.Controls.Add(this.lboxSGDemirbasTuruID);
            this.Controls.Add(this.txtSGDemirbasTuruID);
            this.Controls.Add(this.txtSGadet);
            this.Controls.Add(this.txtSGfiyat);
            this.Controls.Add(this.txtSGdemirbasAdi);
            this.Controls.Add(this.lblSGadet);
            this.Controls.Add(this.btnSGguncelle);
            this.Controls.Add(this.lblSGalimTarihi);
            this.Controls.Add(this.lblSGfiyat);
            this.Controls.Add(this.lblSGdemirbasTuru);
            this.Controls.Add(this.lblSGdemirbasAdi);
            this.Controls.Add(this.btnStokGuncellemeBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Güncelleme";
            this.Load += new System.EventHandler(this.frmStokGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWStokGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStokGuncellemeBack;
        private System.Windows.Forms.TextBox txtSGadet;
        private System.Windows.Forms.TextBox txtSGfiyat;
        private System.Windows.Forms.TextBox txtSGdemirbasAdi;
        private System.Windows.Forms.Label lblSGadet;
        private System.Windows.Forms.Button btnSGguncelle;
        private System.Windows.Forms.Label lblSGalimTarihi;
        private System.Windows.Forms.Label lblSGfiyat;
        private System.Windows.Forms.Label lblSGdemirbasTuru;
        private System.Windows.Forms.Label lblSGdemirbasAdi;
        private System.Windows.Forms.DataGridView DGWStokGuncelleme;
        private System.Windows.Forms.DateTimePicker DtmSGAlimTarihi;
        private System.Windows.Forms.TextBox txtSGDemirbasTuruID;
        private System.Windows.Forms.ListBox lboxSGDemirbasTuruID;
        private System.Windows.Forms.ListBox lboxSGDemirbasTuruAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}