namespace YazılımSınamaProjesi
{
    partial class frmStokEkleme
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
            this.lblSEdemirbasAdi = new System.Windows.Forms.Label();
            this.lblSEdemirbasTuru = new System.Windows.Forms.Label();
            this.lblSEfiyat = new System.Windows.Forms.Label();
            this.lblSEalimTarihi = new System.Windows.Forms.Label();
            this.btnSEekle = new System.Windows.Forms.Button();
            this.lblSEadet = new System.Windows.Forms.Label();
            this.txtSEdemirbasAdi = new System.Windows.Forms.TextBox();
            this.txtSEfiyat = new System.Windows.Forms.TextBox();
            this.txtSEadet = new System.Windows.Forms.TextBox();
            this.btnStokEklemeBack = new System.Windows.Forms.Button();
            this.lboxDemirbasTuruID = new System.Windows.Forms.ListBox();
            this.lboxDemirbasTuruAdi = new System.Windows.Forms.ListBox();
            this.txtDemirbasTuruID = new System.Windows.Forms.TextBox();
            this.dtpAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSEdemirbasAdi
            // 
            this.lblSEdemirbasAdi.AutoSize = true;
            this.lblSEdemirbasAdi.Location = new System.Drawing.Point(32, 89);
            this.lblSEdemirbasAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEdemirbasAdi.Name = "lblSEdemirbasAdi";
            this.lblSEdemirbasAdi.Size = new System.Drawing.Size(112, 17);
            this.lblSEdemirbasAdi.TabIndex = 2;
            this.lblSEdemirbasAdi.Text = "DEMİRBAŞ ADI :";
            // 
            // lblSEdemirbasTuru
            // 
            this.lblSEdemirbasTuru.AutoSize = true;
            this.lblSEdemirbasTuru.Location = new System.Drawing.Point(32, 314);
            this.lblSEdemirbasTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEdemirbasTuru.Name = "lblSEdemirbasTuru";
            this.lblSEdemirbasTuru.Size = new System.Drawing.Size(142, 17);
            this.lblSEdemirbasTuru.TabIndex = 3;
            this.lblSEdemirbasTuru.Text = "DEMİRBAŞ TÜRÜ ID:";
            // 
            // lblSEfiyat
            // 
            this.lblSEfiyat.AutoSize = true;
            this.lblSEfiyat.Location = new System.Drawing.Point(32, 146);
            this.lblSEfiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEfiyat.Name = "lblSEfiyat";
            this.lblSEfiyat.Size = new System.Drawing.Size(54, 17);
            this.lblSEfiyat.TabIndex = 4;
            this.lblSEfiyat.Text = "FİYAT :";
            // 
            // lblSEalimTarihi
            // 
            this.lblSEalimTarihi.AutoSize = true;
            this.lblSEalimTarihi.Location = new System.Drawing.Point(32, 208);
            this.lblSEalimTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEalimTarihi.Name = "lblSEalimTarihi";
            this.lblSEalimTarihi.Size = new System.Drawing.Size(95, 17);
            this.lblSEalimTarihi.TabIndex = 5;
            this.lblSEalimTarihi.Text = "ALIM TARİHİ :";
            // 
            // btnSEekle
            // 
            this.btnSEekle.Location = new System.Drawing.Point(60, 360);
            this.btnSEekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSEekle.Name = "btnSEekle";
            this.btnSEekle.Size = new System.Drawing.Size(293, 70);
            this.btnSEekle.TabIndex = 17;
            this.btnSEekle.Text = "EKLE";
            this.btnSEekle.UseVisualStyleBackColor = true;
            this.btnSEekle.Click += new System.EventHandler(this.btnSEekle_Click);
            // 
            // lblSEadet
            // 
            this.lblSEadet.AutoSize = true;
            this.lblSEadet.Location = new System.Drawing.Point(32, 265);
            this.lblSEadet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEadet.Name = "lblSEadet";
            this.lblSEadet.Size = new System.Drawing.Size(45, 17);
            this.lblSEadet.TabIndex = 12;
            this.lblSEadet.Text = "ADET";
            // 
            // txtSEdemirbasAdi
            // 
            this.txtSEdemirbasAdi.Location = new System.Drawing.Point(182, 86);
            this.txtSEdemirbasAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSEdemirbasAdi.Name = "txtSEdemirbasAdi";
            this.txtSEdemirbasAdi.Size = new System.Drawing.Size(194, 22);
            this.txtSEdemirbasAdi.TabIndex = 13;
            // 
            // txtSEfiyat
            // 
            this.txtSEfiyat.Location = new System.Drawing.Point(182, 143);
            this.txtSEfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtSEfiyat.Name = "txtSEfiyat";
            this.txtSEfiyat.Size = new System.Drawing.Size(80, 22);
            this.txtSEfiyat.TabIndex = 14;
            this.txtSEfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSEfiyat_KeyPress);
            // 
            // txtSEadet
            // 
            this.txtSEadet.Location = new System.Drawing.Point(184, 262);
            this.txtSEadet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSEadet.Name = "txtSEadet";
            this.txtSEadet.Size = new System.Drawing.Size(78, 22);
            this.txtSEadet.TabIndex = 16;
            this.txtSEadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSEadet_KeyPress);
            // 
            // btnStokEklemeBack
            // 
            this.btnStokEklemeBack.FlatAppearance.BorderSize = 0;
            this.btnStokEklemeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEklemeBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnStokEklemeBack.Location = new System.Drawing.Point(16, 15);
            this.btnStokEklemeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokEklemeBack.Name = "btnStokEklemeBack";
            this.btnStokEklemeBack.Size = new System.Drawing.Size(45, 41);
            this.btnStokEklemeBack.TabIndex = 9;
            this.btnStokEklemeBack.UseVisualStyleBackColor = true;
            this.btnStokEklemeBack.Click += new System.EventHandler(this.btnStokEklemeBack_Click);
            // 
            // lboxDemirbasTuruID
            // 
            this.lboxDemirbasTuruID.FormattingEnabled = true;
            this.lboxDemirbasTuruID.ItemHeight = 16;
            this.lboxDemirbasTuruID.Location = new System.Drawing.Point(398, 86);
            this.lboxDemirbasTuruID.Name = "lboxDemirbasTuruID";
            this.lboxDemirbasTuruID.Size = new System.Drawing.Size(119, 164);
            this.lboxDemirbasTuruID.TabIndex = 18;
            this.lboxDemirbasTuruID.SelectedIndexChanged += new System.EventHandler(this.lboxDemirbasTuruID_SelectedIndexChanged);
            // 
            // lboxDemirbasTuruAdi
            // 
            this.lboxDemirbasTuruAdi.Enabled = false;
            this.lboxDemirbasTuruAdi.FormattingEnabled = true;
            this.lboxDemirbasTuruAdi.ItemHeight = 16;
            this.lboxDemirbasTuruAdi.Location = new System.Drawing.Point(536, 86);
            this.lboxDemirbasTuruAdi.Name = "lboxDemirbasTuruAdi";
            this.lboxDemirbasTuruAdi.Size = new System.Drawing.Size(119, 164);
            this.lboxDemirbasTuruAdi.TabIndex = 19;
            // 
            // txtDemirbasTuruID
            // 
            this.txtDemirbasTuruID.Enabled = false;
            this.txtDemirbasTuruID.Location = new System.Drawing.Point(182, 311);
            this.txtDemirbasTuruID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDemirbasTuruID.Name = "txtDemirbasTuruID";
            this.txtDemirbasTuruID.Size = new System.Drawing.Size(80, 22);
            this.txtDemirbasTuruID.TabIndex = 20;
            // 
            // dtpAlimTarihi
            // 
            this.dtpAlimTarihi.Location = new System.Drawing.Point(184, 203);
            this.dtpAlimTarihi.Name = "dtpAlimTarihi";
            this.dtpAlimTarihi.Size = new System.Drawing.Size(192, 22);
            this.dtpAlimTarihi.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStokEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 567);
            this.ControlBox = false;
            this.Controls.Add(this.dtpAlimTarihi);
            this.Controls.Add(this.txtDemirbasTuruID);
            this.Controls.Add(this.lboxDemirbasTuruAdi);
            this.Controls.Add(this.lboxDemirbasTuruID);
            this.Controls.Add(this.txtSEadet);
            this.Controls.Add(this.txtSEfiyat);
            this.Controls.Add(this.txtSEdemirbasAdi);
            this.Controls.Add(this.lblSEadet);
            this.Controls.Add(this.btnStokEklemeBack);
            this.Controls.Add(this.btnSEekle);
            this.Controls.Add(this.lblSEalimTarihi);
            this.Controls.Add(this.lblSEfiyat);
            this.Controls.Add(this.lblSEdemirbasTuru);
            this.Controls.Add(this.lblSEdemirbasAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekleme";
            this.Load += new System.EventHandler(this.frmStokEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSEdemirbasAdi;
        private System.Windows.Forms.Label lblSEdemirbasTuru;
        private System.Windows.Forms.Label lblSEfiyat;
        private System.Windows.Forms.Label lblSEalimTarihi;
        private System.Windows.Forms.Button btnSEekle;
        private System.Windows.Forms.Button btnStokEklemeBack;
        private System.Windows.Forms.Label lblSEadet;
        private System.Windows.Forms.TextBox txtSEdemirbasAdi;
        private System.Windows.Forms.TextBox txtSEfiyat;
        private System.Windows.Forms.TextBox txtSEadet;
        private System.Windows.Forms.ListBox lboxDemirbasTuruID;
        private System.Windows.Forms.ListBox lboxDemirbasTuruAdi;
        private System.Windows.Forms.TextBox txtDemirbasTuruID;
        private System.Windows.Forms.DateTimePicker dtpAlimTarihi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}