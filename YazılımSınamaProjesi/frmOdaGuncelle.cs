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
    public partial class frmOdaGuncelle : Form
    {
        public frmOdaGuncelle()
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
                cboOdaESGodaAdiGuncel.SelectedItem = null;
                cboOdaESGodaAdiGuncel.Items.Add(dr["OdaAdi"]);
            }
            VTkapat();
        }

        private void frmOdaGuncelle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }

        private void btnOdaESGguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                VTbaglan();
                string sorgu = "UPDATE tblOda SET OdaAdi=@odaAdi WHERE OdaAdi=@EodaAdi ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@odaAdi", txtOdaESGyeniOdaAdi.Text);
                komut.Parameters.AddWithValue("@EodaAdi", cboOdaESGodaAdiGuncel.Text);
                komut.ExecuteNonQuery();
                VTkapat();
                MessageBox.Show("Kayıt Başarıyla Güncellendi.");
                cboOdaESGodaAdiGuncel.Text = "";
                txtOdaESGyeniOdaAdi.Text = "";
                cboOdaESGodaAdiGuncel.Items.Clear();
                ComboboxDoldur();
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem...");
            }
        }

        private void btnOdaEkleSilBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();      
        }     
    }
}
