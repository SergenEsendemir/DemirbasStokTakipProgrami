namespace YazılımSınamaProjesi
{
    partial class frmOdaSil
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
            this.lblOdaESGodaAdi3 = new System.Windows.Forms.Label();
            this.btnOdaESGsil = new System.Windows.Forms.Button();
            this.gbOdaSilme = new System.Windows.Forms.GroupBox();
            this.cboOdaESGodaAdiSil = new System.Windows.Forms.ComboBox();
            this.btnOdaEkleSilBack = new System.Windows.Forms.Button();
            this.gbOdaSilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdaESGodaAdi3
            // 
            this.lblOdaESGodaAdi3.AutoSize = true;
            this.lblOdaESGodaAdi3.Location = new System.Drawing.Point(8, 46);
            this.lblOdaESGodaAdi3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaESGodaAdi3.Name = "lblOdaESGodaAdi3";
            this.lblOdaESGodaAdi3.Size = new System.Drawing.Size(72, 17);
            this.lblOdaESGodaAdi3.TabIndex = 17;
            this.lblOdaESGodaAdi3.Text = "ODA ADI :";
            // 
            // btnOdaESGsil
            // 
            this.btnOdaESGsil.Location = new System.Drawing.Point(288, 40);
            this.btnOdaESGsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaESGsil.Name = "btnOdaESGsil";
            this.btnOdaESGsil.Size = new System.Drawing.Size(100, 28);
            this.btnOdaESGsil.TabIndex = 18;
            this.btnOdaESGsil.Text = "SİL";
            this.btnOdaESGsil.UseVisualStyleBackColor = true;
            this.btnOdaESGsil.Click += new System.EventHandler(this.btnOdaESGsil_Click);
            // 
            // gbOdaSilme
            // 
            this.gbOdaSilme.Controls.Add(this.cboOdaESGodaAdiSil);
            this.gbOdaSilme.Controls.Add(this.lblOdaESGodaAdi3);
            this.gbOdaSilme.Controls.Add(this.btnOdaESGsil);
            this.gbOdaSilme.Location = new System.Drawing.Point(16, 83);
            this.gbOdaSilme.Margin = new System.Windows.Forms.Padding(4);
            this.gbOdaSilme.Name = "gbOdaSilme";
            this.gbOdaSilme.Padding = new System.Windows.Forms.Padding(4);
            this.gbOdaSilme.Size = new System.Drawing.Size(624, 123);
            this.gbOdaSilme.TabIndex = 27;
            this.gbOdaSilme.TabStop = false;
            this.gbOdaSilme.Text = "ODA SİLME";
            // 
            // cboOdaESGodaAdiSil
            // 
            this.cboOdaESGodaAdiSil.FormattingEnabled = true;
            this.cboOdaESGodaAdiSil.Location = new System.Drawing.Point(92, 42);
            this.cboOdaESGodaAdiSil.Margin = new System.Windows.Forms.Padding(4);
            this.cboOdaESGodaAdiSil.Name = "cboOdaESGodaAdiSil";
            this.cboOdaESGodaAdiSil.Size = new System.Drawing.Size(147, 24);
            this.cboOdaESGodaAdiSil.TabIndex = 19;
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
            // frmOdaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 255);
            this.ControlBox = false;
            this.Controls.Add(this.gbOdaSilme);
            this.Controls.Add(this.btnOdaEkleSilBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Sil";
            this.Load += new System.EventHandler(this.frmOdaSil_Load);
            this.gbOdaSilme.ResumeLayout(false);
            this.gbOdaSilme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkleSilBack;
        private System.Windows.Forms.Label lblOdaESGodaAdi3;
        private System.Windows.Forms.Button btnOdaESGsil;
        private System.Windows.Forms.GroupBox gbOdaSilme;
        private System.Windows.Forms.ComboBox cboOdaESGodaAdiSil;
    }
}