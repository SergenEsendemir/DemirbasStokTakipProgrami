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
    public partial class frmOdaSil : Form
    {
        public frmOdaSil()
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

        void ComboboxDoldur()
        {
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblOda";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cboOdaESGodaAdiSil.Items.Add(dr["OdaAdi"]);
            }
            VTkapat();
        }
        private void btnOdaEkleSilBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }
        private void frmOdaSil_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }
        private void btnOdaESGsil_Click(object sender, EventArgs e)
        {
            VTbaglan();
            string sorgu = "DELETE FROM tblOda WHERE OdaAdi=@odaAdi ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@odaAdi", cboOdaESGodaAdiSil.Text);
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Kayıt Başarıyla Silindi.");
            cboOdaESGodaAdiSil.Text = "";
            cboOdaESGodaAdiSil.Items.Clear();
            ComboboxDoldur();
        }

       
        
    }
}
