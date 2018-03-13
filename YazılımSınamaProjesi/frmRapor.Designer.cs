namespace YazılımSınamaProjesi
{
    partial class frmRapor
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
            this.btnAramalarBack = new System.Windows.Forms.Button();
            this.dgwRapor = new System.Windows.Forms.DataGridView();
            this.btnRaporArama = new System.Windows.Forms.Button();
            this.cmbRapor = new System.Windows.Forms.ComboBox();
            this.lblRaporOdaAdi = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.PpdDialog = new System.Windows.Forms.PrintDialog();
            this.PDYazici = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAramalarBack
            // 
            this.btnAramalarBack.FlatAppearance.BorderSize = 0;
            this.btnAramalarBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAramalarBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnAramalarBack.Location = new System.Drawing.Point(13, 13);
            this.btnAramalarBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAramalarBack.Name = "btnAramalarBack";
            this.btnAramalarBack.Size = new System.Drawing.Size(45, 41);
            this.btnAramalarBack.TabIndex = 1;
            this.btnAramalarBack.UseVisualStyleBackColor = true;
            this.btnAramalarBack.Click += new System.EventHandler(this.btnAramalarBack_Click);
            // 
            // dgwRapor
            // 
            this.dgwRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRapor.Location = new System.Drawing.Point(68, 107);
            this.dgwRapor.Margin = new System.Windows.Forms.Padding(4);
            this.dgwRapor.Name = "dgwRapor";
            this.dgwRapor.ReadOnly = true;
            this.dgwRapor.Size = new System.Drawing.Size(699, 227);
            this.dgwRapor.TabIndex = 2;
            // 
            // btnRaporArama
            // 
            this.btnRaporArama.Location = new System.Drawing.Point(483, 41);
            this.btnRaporArama.Name = "btnRaporArama";
            this.btnRaporArama.Size = new System.Drawing.Size(75, 23);
            this.btnRaporArama.TabIndex = 3;
            this.btnRaporArama.Text = "Listele";
            this.btnRaporArama.UseVisualStyleBackColor = true;
            this.btnRaporArama.Click += new System.EventHandler(this.btnRaporArama_Click);
            // 
            // cmbRapor
            // 
            this.cmbRapor.FormattingEnabled = true;
            this.cmbRapor.Location = new System.Drawing.Point(343, 41);
            this.cmbRapor.Name = "cmbRapor";
            this.cmbRapor.Size = new System.Drawing.Size(121, 24);
            this.cmbRapor.TabIndex = 4;
            // 
            // lblRaporOdaAdi
            // 
            this.lblRaporOdaAdi.AutoSize = true;
            this.lblRaporOdaAdi.Location = new System.Drawing.Point(270, 44);
            this.lblRaporOdaAdi.Name = "lblRaporOdaAdi";
            this.lblRaporOdaAdi.Size = new System.Drawing.Size(67, 17);
            this.lblRaporOdaAdi.TabIndex = 5;
            this.lblRaporOdaAdi.Text = "Oda Adı :";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(329, 367);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(253, 49);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // PpdDialog
            // 
            this.PpdDialog.UseEXDialog = true;
            // 
            // PDYazici
            // 
            this.PDYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PDYazici_PrintPage);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.ControlBox = false;
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblRaporOdaAdi);
            this.Controls.Add(this.cmbRapor);
            this.Controls.Add(this.btnRaporArama);
            this.Controls.Add(this.dgwRapor);
            this.Controls.Add(this.btnAramalarBack);
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAramalarBack;
        private System.Windows.Forms.DataGridView dgwRapor;
        private System.Windows.Forms.Button btnRaporArama;
        private System.Windows.Forms.ComboBox cmbRapor;
        private System.Windows.Forms.Label lblRaporOdaAdi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.PrintDialog PpdDialog;
        private System.Drawing.Printing.PrintDocument PDYazici;
    }
}