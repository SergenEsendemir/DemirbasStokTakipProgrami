namespace YazılımSınamaProjesi
{
    partial class frmOdaEkle
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
            this.lblOdaESGodaAdi = new System.Windows.Forms.Label();
            this.txtOdaESGodaAdi = new System.Windows.Forms.TextBox();
            this.btnOdaESGekle = new System.Windows.Forms.Button();
            this.gbOdaEkleme = new System.Windows.Forms.GroupBox();
            this.txtDepartmanID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxDepartmanAdi = new System.Windows.Forms.ListBox();
            this.lboxDepartmanID = new System.Windows.Forms.ListBox();
            this.btnOdaEkleSilBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbOdaEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdaESGodaAdi
            // 
            this.lblOdaESGodaAdi.AutoSize = true;
            this.lblOdaESGodaAdi.Location = new System.Drawing.Point(8, 41);
            this.lblOdaESGodaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaESGodaAdi.Name = "lblOdaESGodaAdi";
            this.lblOdaESGodaAdi.Size = new System.Drawing.Size(72, 17);
            this.lblOdaESGodaAdi.TabIndex = 14;
            this.lblOdaESGodaAdi.Text = "ODA ADI :";
            // 
            // txtOdaESGodaAdi
            // 
            this.txtOdaESGodaAdi.Location = new System.Drawing.Point(119, 36);
            this.txtOdaESGodaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdaESGodaAdi.Name = "txtOdaESGodaAdi";
            this.txtOdaESGodaAdi.Size = new System.Drawing.Size(132, 22);
            this.txtOdaESGodaAdi.TabIndex = 15;
            // 
            // btnOdaESGekle
            // 
            this.btnOdaESGekle.Location = new System.Drawing.Point(138, 114);
            this.btnOdaESGekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdaESGekle.Name = "btnOdaESGekle";
            this.btnOdaESGekle.Size = new System.Drawing.Size(100, 28);
            this.btnOdaESGekle.TabIndex = 16;
            this.btnOdaESGekle.Text = "EKLE";
            this.btnOdaESGekle.UseVisualStyleBackColor = true;
            this.btnOdaESGekle.Click += new System.EventHandler(this.btnOdaESGekle_Click);
            // 
            // gbOdaEkleme
            // 
            this.gbOdaEkleme.Controls.Add(this.txtDepartmanID);
            this.gbOdaEkleme.Controls.Add(this.label1);
            this.gbOdaEkleme.Controls.Add(this.lboxDepartmanAdi);
            this.gbOdaEkleme.Controls.Add(this.lboxDepartmanID);
            this.gbOdaEkleme.Controls.Add(this.txtOdaESGodaAdi);
            this.gbOdaEkleme.Controls.Add(this.lblOdaESGodaAdi);
            this.gbOdaEkleme.Controls.Add(this.btnOdaESGekle);
            this.gbOdaEkleme.Location = new System.Drawing.Point(24, 63);
            this.gbOdaEkleme.Margin = new System.Windows.Forms.Padding(4);
            this.gbOdaEkleme.Name = "gbOdaEkleme";
            this.gbOdaEkleme.Padding = new System.Windows.Forms.Padding(4);
            this.gbOdaEkleme.Size = new System.Drawing.Size(624, 164);
            this.gbOdaEkleme.TabIndex = 25;
            this.gbOdaEkleme.TabStop = false;
            this.gbOdaEkleme.Text = "ODA EKLEME";
            // 
            // txtDepartmanID
            // 
            this.txtDepartmanID.Enabled = false;
            this.txtDepartmanID.Location = new System.Drawing.Point(118, 73);
            this.txtDepartmanID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmanID.Name = "txtDepartmanID";
            this.txtDepartmanID.Size = new System.Drawing.Size(132, 22);
            this.txtDepartmanID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "DEPARTMAN :";
            // 
            // lboxDepartmanAdi
            // 
            this.lboxDepartmanAdi.FormattingEnabled = true;
            this.lboxDepartmanAdi.ItemHeight = 16;
            this.lboxDepartmanAdi.Location = new System.Drawing.Point(485, 22);
            this.lboxDepartmanAdi.Name = "lboxDepartmanAdi";
            this.lboxDepartmanAdi.Size = new System.Drawing.Size(120, 132);
            this.lboxDepartmanAdi.TabIndex = 18;
            // 
            // lboxDepartmanID
            // 
            this.lboxDepartmanID.FormattingEnabled = true;
            this.lboxDepartmanID.ItemHeight = 16;
            this.lboxDepartmanID.Location = new System.Drawing.Point(356, 22);
            this.lboxDepartmanID.Name = "lboxDepartmanID";
            this.lboxDepartmanID.Size = new System.Drawing.Size(120, 132);
            this.lboxDepartmanID.TabIndex = 17;
            this.lboxDepartmanID.SelectedIndexChanged += new System.EventHandler(this.lboxDepartmanID_SelectedIndexChanged);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 289);
            this.ControlBox = false;
            this.Controls.Add(this.gbOdaEkleme);
            this.Controls.Add(this.btnOdaEkleSilBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Ekle";
            this.Load += new System.EventHandler(this.frmOdaEkle_Load);
            this.gbOdaEkleme.ResumeLayout(false);
            this.gbOdaEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkleSilBack;
        private System.Windows.Forms.Label lblOdaESGodaAdi;
        private System.Windows.Forms.TextBox txtOdaESGodaAdi;
        private System.Windows.Forms.Button btnOdaESGekle;
        private System.Windows.Forms.GroupBox gbOdaEkleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxDepartmanAdi;
        private System.Windows.Forms.ListBox lboxDepartmanID;
        private System.Windows.Forms.TextBox txtDepartmanID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}