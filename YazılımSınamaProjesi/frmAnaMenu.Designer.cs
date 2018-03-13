namespace YazılımSınamaProjesi
{
    partial class frmAnaMenu
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
            this.btnArama = new System.Windows.Forms.Button();
            this.btnOdaDemirbasIslemleri = new System.Windows.Forms.Button();
            this.btnOdaTanimlama = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(1, 2);
            this.btnArama.Margin = new System.Windows.Forms.Padding(4);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(327, 279);
            this.btnArama.TabIndex = 1;
            this.btnArama.Text = "ARAMALAR";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnOdaDemirbasIslemleri
            // 
            this.btnOdaDemirbasIslemleri.Location = new System.Drawing.Point(336, 2);
            this.btnOdaDemirbasIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaDemirbasIslemleri.Name = "btnOdaDemirbasIslemleri";
            this.btnOdaDemirbasIslemleri.Size = new System.Drawing.Size(308, 279);
            this.btnOdaDemirbasIslemleri.TabIndex = 2;
            this.btnOdaDemirbasIslemleri.Text = "ODA DEMİRBAŞ İŞLEMLERİ";
            this.btnOdaDemirbasIslemleri.UseVisualStyleBackColor = true;
            this.btnOdaDemirbasIslemleri.Click += new System.EventHandler(this.btnOdaDemirbas_Click);
            // 
            // btnOdaTanimlama
            // 
            this.btnOdaTanimlama.Location = new System.Drawing.Point(1, 354);
            this.btnOdaTanimlama.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaTanimlama.Name = "btnOdaTanimlama";
            this.btnOdaTanimlama.Size = new System.Drawing.Size(327, 277);
            this.btnOdaTanimlama.TabIndex = 3;
            this.btnOdaTanimlama.Text = "ODA TANIMLAMA";
            this.btnOdaTanimlama.UseVisualStyleBackColor = true;
            this.btnOdaTanimlama.Click += new System.EventHandler(this.btnOdaTanimlama_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(336, 354);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(308, 277);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "ADMİN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(643, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rapor Çıktısı Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOdaTanimlama);
            this.Controls.Add(this.btnOdaDemirbasIslemleri);
            this.Controls.Add(this.btnArama);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA MENÜ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.ANA_MENÜ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnOdaDemirbasIslemleri;
        private System.Windows.Forms.Button btnOdaTanimlama;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
    }
}