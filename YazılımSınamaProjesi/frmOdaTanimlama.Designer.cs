namespace YazılımSınamaProjesi
{
    partial class frmOdaTanimlama
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
            this.btnOTodaKaydet = new System.Windows.Forms.Button();
            this.btnTanimlamaBack = new System.Windows.Forms.Button();
            this.txtOTodaAdi = new System.Windows.Forms.TextBox();
            this.lblOTodaAdi = new System.Windows.Forms.Label();
            this.lblOTodaSorumlusu = new System.Windows.Forms.Label();
            this.txtOTOdaSorumlusu = new System.Windows.Forms.TextBox();
            this.dGWOda = new System.Windows.Forms.DataGridView();
            this.dGWPersonel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGWOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOTodaKaydet
            // 
            this.btnOTodaKaydet.Location = new System.Drawing.Point(234, 396);
            this.btnOTodaKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnOTodaKaydet.Name = "btnOTodaKaydet";
            this.btnOTodaKaydet.Size = new System.Drawing.Size(197, 81);
            this.btnOTodaKaydet.TabIndex = 6;
            this.btnOTodaKaydet.Text = "KAYDET";
            this.btnOTodaKaydet.UseVisualStyleBackColor = true;
            this.btnOTodaKaydet.Click += new System.EventHandler(this.btnOTodaKaydet_Click);
            // 
            // btnTanimlamaBack
            // 
            this.btnTanimlamaBack.FlatAppearance.BorderSize = 0;
            this.btnTanimlamaBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanimlamaBack.Image = global::YazılımSınamaProjesi.Properties.Resources.back;
            this.btnTanimlamaBack.Location = new System.Drawing.Point(16, 15);
            this.btnTanimlamaBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnTanimlamaBack.Name = "btnTanimlamaBack";
            this.btnTanimlamaBack.Size = new System.Drawing.Size(45, 41);
            this.btnTanimlamaBack.TabIndex = 1;
            this.btnTanimlamaBack.UseVisualStyleBackColor = true;
            this.btnTanimlamaBack.Click += new System.EventHandler(this.btnTanimlamaBack_Click);
            // 
            // txtOTodaAdi
            // 
            this.txtOTodaAdi.Enabled = false;
            this.txtOTodaAdi.Location = new System.Drawing.Point(144, 310);
            this.txtOTodaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTodaAdi.Name = "txtOTodaAdi";
            this.txtOTodaAdi.Size = new System.Drawing.Size(160, 22);
            this.txtOTodaAdi.TabIndex = 2;
            // 
            // lblOTodaAdi
            // 
            this.lblOTodaAdi.AutoSize = true;
            this.lblOTodaAdi.Location = new System.Drawing.Point(69, 313);
            this.lblOTodaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOTodaAdi.Name = "lblOTodaAdi";
            this.lblOTodaAdi.Size = new System.Drawing.Size(67, 17);
            this.lblOTodaAdi.TabIndex = 4;
            this.lblOTodaAdi.Text = "Oda Adı :";
            // 
            // lblOTodaSorumlusu
            // 
            this.lblOTodaSorumlusu.AutoSize = true;
            this.lblOTodaSorumlusu.Location = new System.Drawing.Point(328, 313);
            this.lblOTodaSorumlusu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOTodaSorumlusu.Name = "lblOTodaSorumlusu";
            this.lblOTodaSorumlusu.Size = new System.Drawing.Size(114, 17);
            this.lblOTodaSorumlusu.TabIndex = 5;
            this.lblOTodaSorumlusu.Text = "Oda Sorumlusu :";
            // 
            // txtOTOdaSorumlusu
            // 
            this.txtOTOdaSorumlusu.Enabled = false;
            this.txtOTOdaSorumlusu.Location = new System.Drawing.Point(441, 310);
            this.txtOTOdaSorumlusu.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTOdaSorumlusu.Name = "txtOTOdaSorumlusu";
            this.txtOTOdaSorumlusu.Size = new System.Drawing.Size(160, 22);
            this.txtOTOdaSorumlusu.TabIndex = 7;
            // 
            // dGWOda
            // 
            this.dGWOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWOda.Location = new System.Drawing.Point(12, 74);
            this.dGWOda.Name = "dGWOda";
            this.dGWOda.ReadOnly = true;
            this.dGWOda.RowTemplate.Height = 24;
            this.dGWOda.Size = new System.Drawing.Size(320, 172);
            this.dGWOda.TabIndex = 8;
            this.dGWOda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWOda_RowEnter);
            // 
            // dGWPersonel
            // 
            this.dGWPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWPersonel.Location = new System.Drawing.Point(350, 74);
            this.dGWPersonel.Name = "dGWPersonel";
            this.dGWPersonel.ReadOnly = true;
            this.dGWPersonel.RowTemplate.Height = 24;
            this.dGWPersonel.Size = new System.Drawing.Size(323, 172);
            this.dGWPersonel.TabIndex = 9;
            this.dGWPersonel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWPersonel_RowEnter);
            // 
            // frmOdaTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 567);
            this.ControlBox = false;
            this.Controls.Add(this.dGWPersonel);
            this.Controls.Add(this.dGWOda);
            this.Controls.Add(this.txtOTOdaSorumlusu);
            this.Controls.Add(this.btnOTodaKaydet);
            this.Controls.Add(this.lblOTodaSorumlusu);
            this.Controls.Add(this.lblOTodaAdi);
            this.Controls.Add(this.txtOTodaAdi);
            this.Controls.Add(this.btnTanimlamaBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Tanımlama";
            this.Load += new System.EventHandler(this.frmOdaTanimlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWOda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTanimlamaBack;
        private System.Windows.Forms.Button btnOTodaKaydet;
        private System.Windows.Forms.TextBox txtOTodaAdi;
        private System.Windows.Forms.Label lblOTodaAdi;
        private System.Windows.Forms.Label lblOTodaSorumlusu;
        private System.Windows.Forms.TextBox txtOTOdaSorumlusu;
        private System.Windows.Forms.DataGridView dGWOda;
        private System.Windows.Forms.DataGridView dGWPersonel;
    }
}