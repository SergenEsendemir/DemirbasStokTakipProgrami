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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu(Form f)
        {
            InitializeComponent();
            f.Close();
        }

        SqlConnection baglanti;
        SqlCommand sc;
        DataTable dt;
        SqlDataReader okuyucu;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        private void ANA_MENÜ_Load(object sender, EventArgs e)
        {
            string k = GİRİŞ_EKRANI.kAdi;
            string s = GİRİŞ_EKRANI.sifre;
            VTbaglan();
            sc = new SqlCommand("SELECT YetkiID FROM tblKullanicilar WHERE KullaniciAdi='" +k + "' AND Sifre='" + s + "'" , baglanti);
            okuyucu = sc.ExecuteReader();
            dt = new DataTable();
            while (okuyucu.Read())         
            {
                string yetki =okuyucu[0].ToString();
                if(yetki=="True")
                    btnAdmin.Enabled = true;
                else
                {
                    btnAdmin.Enabled = false;
                }
            }
            VTkapat();

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            frmAramalar frmarama = new frmAramalar();
            frmarama.Show();
            this.Hide();
        }

        private void btnOdaDemirbas_Click(object sender, EventArgs e)
        {
            frmDemirbasIslem frmdemirbasislem = new frmDemirbasIslem();
            frmdemirbasislem.Show();
            this.Hide();
        }

        private void btnOdaTanimlama_Click(object sender, EventArgs e)
        {
            frmOdaTanimlama frmodatanimla = new frmOdaTanimlama();
            frmodatanimla.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void frmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRapor frmrapor = new frmRapor();
            frmrapor.Show();
            this.Hide();
        }
    }
}
