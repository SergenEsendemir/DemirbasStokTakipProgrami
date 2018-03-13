using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazılımSınamaProjesi
{
    public partial class frmOdaEkle: Form
    {
        public frmOdaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        private void frmOdaEkle_Load(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblDepartmanlar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lboxDepartmanID.Items.Add(dr["DepartmanID"]);
                lboxDepartmanAdi.Items.Add(dr["DepartmanAdi"]);
            }
            VTkapat();
        }
        private void btnOdaESGekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOdaESGodaAdi.Text.Trim() == "") errorProvider1.SetError(txtOdaESGodaAdi, "Boş geçilmez");
                else errorProvider1.SetError(txtOdaESGodaAdi, "");
                if (txtOdaESGodaAdi.Text.Trim() != "")
                {
                    VTbaglan();
                    komut = new SqlCommand("insert into tblOda(OdaAdi,DepartmanID) values (@odaAdi,@ID)", baglanti);
                    komut.Parameters.AddWithValue("@odaAdi", txtOdaESGodaAdi.Text);
                    komut.Parameters.AddWithValue("@ID", txtDepartmanID.Text);
                    komut.ExecuteNonQuery();
                    VTkapat();
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                    }
                    MessageBox.Show("Oda başarıyla eklendi.");
                }
            }
            catch
            {
                MessageBox.Show("Kayıtlı Oda...");
                VTkapat();   
            }
        }

        private void btnOdaEkleSilBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();

          
        }

        private void lboxDepartmanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDepartmanID.Text = lboxDepartmanID.SelectedItem.ToString();
        }

       
        
    }
}
