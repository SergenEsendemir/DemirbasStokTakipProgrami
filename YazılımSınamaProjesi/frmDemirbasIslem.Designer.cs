namespace YazılımSınamaProjesi
{
    partial class frmDemirbasIslem
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
            this.lblDIOdaAdi = new System.Windows.Forms.Label();
            this.lblDIDemirbasAdi = new System.Windows.Forms.Label();
            this.lblDIAdet = new System.Windows.Forms.Label();
            this.dgwDemirbasListesi = new System.Windows.Forms.DataGridView();
            this.btnDemirbasBack = new System.Windows.Forms.Button();
            this.txtDIAdet = new System.Windows.Forms.TextBox();
            this.btnDemirbasIslemKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwDemirbas = new System.Windows.Forms.DataGridView();
            this.dgwOdalar = new System.Windows.Forms.DataGridView();
            this.txtDemirbasAdi = new System.Windows.Forms.TextBox();
            this.txtOdaAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemirbasListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdalar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDIOdaAdi
            // 
            this.lblDIOdaAdi.AutoSize = true;
            this.lblDIOdaAdi.Location = new System.Drawing.Point(6, 223);
            this.lblDIOdaAdi.Name = "lblDIOdaAdi";
            this.lblDIOdaAdi.Size = new System.Drawing.Size(57, 13);
            this.lblDIOdaAdi.TabIndex = 2;
            this.lblDIOdaAdi.Text = "ODA ADI :";
            // 
            // lblDIDemirbasAdi
            // 
            this.lblDIDemirbasAdi.AutoSize = true;
            this.lblDIDemirbasAdi.Location = new System.Drawing.Point(286, 223);
            this.lblDIDemirbasAdi.Name = "lblDIDemirbasAdi";
            this.lblDIDemirbasAdi.Size = new System.Drawing.Size(90, 13);
            this.lblDIDemirbasAdi.TabIndex = 3;
            this.lblDIDemirbasAdi.Text = "DEMİRBAŞ ADI :";
            // 
            // lblDIAdet
            // 
            this.lblDIAdet.AutoSize = true;
            this.lblDIAdet.Location = new System.Drawing.Point(179, 261);
            this.lblDIAdet.Name = "lblDIAdet";
            this.lblDIAdet.Size = new System.Drawing.Size(42, 13);
            this.lblDIAdet.TabIndex = 4;
            this.lblDIAdet.Text = "ADET :";
            // 
            // dgwDemirbasListesi
            // 
            this.dgwDemirbasListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDemirbasListesi.Location = new System.Drawing.Point(6, 19);
            this.dgwDemirbasListesi.Name = "dgwDemirbasListesi";
            this.dgwDemirbasListesi.ReadOnly = true;
            this.dgwDemirbasListesi.Size = new System.Drawing.Size(347, 176);
            this.dgwDemirbasListesi.TabIndex = 11;
            // 
            // btnDemirbasBack
            // 
            this.btnDemirbasBack.FlatAppearance.BorderSize = 0;
            this.btnDemirbasBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbasBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnDemirbasBack.Location = new System.Drawing.Point(12, 12);
            this.btnDemirbasBack.Name = "btnDemirbasBack";
            this.btnDemirbasBack.Size = new System.Drawing.Size(34, 33);
            this.btnDemirbasBack.TabIndex = 1;
            this.btnDemirbasBack.UseVisualStyleBackColor = true;
            this.btnDemirbasBack.Click += new System.EventHandler(this.btnDemirbasBack_Click);
            // 
            // txtDIAdet
            // 
            this.txtDIAdet.Location = new System.Drawing.Point(240, 258);
            this.txtDIAdet.Name = "txtDIAdet";
            this.txtDIAdet.Size = new System.Drawing.Size(121, 20);
            this.txtDIAdet.TabIndex = 15;
            this.txtDIAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIAdet_KeyPress);
            // 
            // btnDemirbasIslemKaydet
            // 
            this.btnDemirbasIslemKaydet.Location = new System.Drawing.Point(224, 306);
            this.btnDemirbasIslemKaydet.Name = "btnDemirbasIslemKaydet";
            this.btnDemirbasIslemKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnDemirbasIslemKaydet.TabIndex = 16;
            this.btnDemirbasIslemKaydet.Text = "KAYDET";
            this.btnDemirbasIslemKaydet.UseVisualStyleBackColor = true;
            this.btnDemirbasIslemKaydet.Click += new System.EventHandler(this.btnDemirbasIslemKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwDemirbas);
            this.groupBox1.Controls.Add(this.dgwOdalar);
            this.groupBox1.Controls.Add(this.txtDemirbasAdi);
            this.groupBox1.Controls.Add(this.txtOdaAdi);
            this.groupBox1.Controls.Add(this.lblDIOdaAdi);
            this.groupBox1.Controls.Add(this.btnDemirbasIslemKaydet);
            this.groupBox1.Controls.Add(this.lblDIDemirbasAdi);
            this.groupBox1.Controls.Add(this.txtDIAdet);
            this.groupBox1.Controls.Add(this.lblDIAdet);
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 361);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demirbaş ekle";
            // 
            // dgwDemirbas
            // 
            this.dgwDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDemirbas.Location = new System.Drawing.Point(352, 19);
            this.dgwDemirbas.Name = "dgwDemirbas";
            this.dgwDemirbas.ReadOnly = true;
            this.dgwDemirbas.Size = new System.Drawing.Size(318, 176);
            this.dgwDemirbas.TabIndex = 20;
            this.dgwDemirbas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDemirbas_RowEnter);
            // 
            // dgwOdalar
            // 
            this.dgwOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOdalar.Location = new System.Drawing.Point(8, 19);
            this.dgwOdalar.Name = "dgwOdalar";
            this.dgwOdalar.ReadOnly = true;
            this.dgwOdalar.Size = new System.Drawing.Size(328, 176);
            this.dgwOdalar.TabIndex = 19;
            this.dgwOdalar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOdalar_RowEnter);
            // 
            // txtDemirbasAdi
            // 
            this.txtDemirbasAdi.Enabled = false;
            this.txtDemirbasAdi.Location = new System.Drawing.Point(382, 220);
            this.txtDemirbasAdi.Name = "txtDemirbasAdi";
            this.txtDemirbasAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDemirbasAdi.TabIndex = 18;
            // 
            // txtOdaAdi
            // 
            this.txtOdaAdi.Enabled = false;
            this.txtOdaAdi.Location = new System.Drawing.Point(99, 220);
            this.txtOdaAdi.Name = "txtOdaAdi";
            this.txtOdaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtOdaAdi.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwDemirbasListesi);
            this.groupBox2.Location = new System.Drawing.Point(706, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 251);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demirbaş listesi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDemirbasIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 486);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDemirbasBack);
            this.Name = "frmDemirbasIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş İslem";
            this.Load += new System.EventHandler(this.frmDemirbasIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemirbasListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDemirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdalar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDemirbasBack;
        private System.Windows.Forms.Label lblDIOdaAdi;
        private System.Windows.Forms.Label lblDIDemirbasAdi;
        private System.Windows.Forms.Label lblDIAdet;
        private System.Windows.Forms.DataGridView dgwDemirbasListesi;
        private System.Windows.Forms.TextBox txtDIAdet;
        private System.Windows.Forms.Button btnDemirbasIslemKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwDemirbas;
        private System.Windows.Forms.DataGridView dgwOdalar;
        private System.Windows.Forms.TextBox txtDemirbasAdi;
        private System.Windows.Forms.TextBox txtOdaAdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}