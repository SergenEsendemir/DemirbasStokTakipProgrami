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
    public partial class frmAramalar : Form
    {
        public frmAramalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataAdapter da,da1;
        DataSet ds,ds1;
        public void HarfGirisiKontrol(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        public void dgwDemirbasAramalarDoldur()
        {
            VTbaglan();
            da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblDemirbas");
            dgwAramalarDemirbas.DataSource = ds.Tables["tblDemirbas"];
            VTkapat();
        }

        public void dgwPersonelAramaDoldur()
        {
            VTbaglan();
            string ad = txtAramalarAd.Text;
            string soyad = txtAramalarSoyad.Text;
            da1 = new SqlDataAdapter("SELECT PersonelAdi,PersonelSoyadi,ODT.DemirbasID,DemirbasAdi,AlinanAdet FROM tblPersonel P INNER JOIN tblOdaDemirbasAtama ODT ON P.PersonelID=ODT.PersonelID INNER JOIN tblDemirbas D ON D.DemirbasID=ODT.DemirbasID", baglanti);
            ds1 = new DataSet();
            da1.Fill(ds1, "tblPersonel");
            dgwAramalarPersonel.DataSource = ds1.Tables["tblPersonel"];
            VTkapat();
        }

        public void dtmGizle()
        {
            dtmBilgi.Visible = false;
            txtAramalarBilgiGiriniz.Visible = true;
        }
        public void dtmGoster()
        {
            dtmBilgi.Visible = true;
            txtAramalarBilgiGiriniz.Visible = false;
        }
        private void frmAramalar_Load(object sender, EventArgs e)
        {
            dtmBilgi.Visible = false;
            dgwAramalarDemirbas.AllowUserToAddRows = false;
            dgwAramalarPersonel.AllowUserToAddRows = false;
            dgwDemirbasAramalarDoldur();
            dgwPersonelAramaDoldur();
        }
        private void btnAramalarArama_Click(object sender, EventArgs e)
        {
            try
            {


                VTbaglan();
                string ad = txtAramalarAd.Text;
                string soyad = txtAramalarSoyad.Text;
                da = new SqlDataAdapter("SELECT PersonelAdi,PersonelSoyadi,ODT.DemirbasID,DemirbasAdi,AlinanAdet FROM tblPersonel P INNER JOIN tblOdaDemirbasAtama ODT ON P.PersonelID=ODT.PersonelID INNER JOIN tblDemirbas D ON D.DemirbasID=ODT.DemirbasID WHERE PersonelAdi='" + ad + "' AND PersonelSoyadi='" + soyad + "'", baglanti);
                ds = new DataSet();
                da.Fill(ds, "tblPersonel");
                dgwAramalarPersonel.DataSource = ds.Tables["tblPersonel"];
                VTkapat();
                txtAramalarAd.Text = "";
                txtAramalarSoyad.Text = "";
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem!!");
            }
        }
        private void btnAramalarBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void btnDemirbasArama_Click(object sender, EventArgs e)
        {
            dgwAramalarDemirbas.AllowUserToAddRows=false;

            try
            {
                if (txtAramalarBilgiGiriniz.Text.Trim() == "") errorProvider1.SetError(txtAramalarBilgiGiriniz, "Boş geçilmez");
                else errorProvider1.SetError(txtAramalarBilgiGiriniz, "");
                if (txtAramalarBilgiGiriniz.Text.Trim() != "")
                {
                    VTbaglan();
                    if (rdbDemirbasAdi.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID WHERE DemirbasAdi='" + txtAramalarBilgiGiriniz.Text + "'", baglanti);
                    }
                    if (rdbDemirbasTuru.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID WHERE DemirbasTuruAdi='" + txtAramalarBilgiGiriniz.Text + "'", baglanti);
                    }
                    if (rdbFiyat.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID WHERE Fiyat='" + txtAramalarBilgiGiriniz.Text + "'", baglanti);
                    }
                    if (rdbAlimTarihi.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID WHERE AlimTarihi LIKE '%" + dtmBilgi.Value.ToString("yyyy-MM-dd") + "%'", baglanti);
                    }
                    if (rdbAdet.Checked == true)
                    {
                        da = new SqlDataAdapter("SELECT DemirbasAdi,DT.DemirbasTuruAdi,Fiyat,AlimTarihi,Adet FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID WHERE Adet='" + txtAramalarBilgiGiriniz.Text + "'", baglanti);
                    }
                    ds = new DataSet();
                    da.Fill(ds, "tblDemirbas");
                    dgwAramalarDemirbas.DataSource = ds.Tables["tblDemirbas"];
                    VTkapat();
                    txtAramalarBilgiGiriniz.Text = "";
                    
                }
            }
            catch
            {
                MessageBox.Show("Hata Oluştu.Lütfen tekrar deneyiniz...");
            }
        }

        private void rdbAlimTarihi_CheckedChanged(object sender, EventArgs e)
        {
            dtmGoster();
            dgwDemirbasAramalarDoldur();
        }

        private void rdbDemirbasAdi_CheckedChanged(object sender, EventArgs e)
        {
            dtmGizle();
            dgwDemirbasAramalarDoldur();
        }

        private void rdbDemirbasTuru_CheckedChanged(object sender, EventArgs e)
        {
            dtmGizle();
            dgwDemirbasAramalarDoldur();
        }

        private void rdbFiyat_CheckedChanged(object sender, EventArgs e)
        {
            dtmGizle();
            dgwDemirbasAramalarDoldur();
        }

        private void rdbAdet_CheckedChanged(object sender, EventArgs e)
        {
            dtmGizle();
            dgwDemirbasAramalarDoldur();
        }

        private void txtAramalarAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            HarfGirisiKontrol(e);
        }

        private void txtAramalarSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            HarfGirisiKontrol(e);
        }
    }
}
