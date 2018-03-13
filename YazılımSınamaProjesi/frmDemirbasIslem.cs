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
    public partial class frmDemirbasIslem : Form
    {
        public frmDemirbasIslem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds, ds1,ds2;
        SqlDataAdapter da, da1,da2;
        string odaID, demirbasID,personelID;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }
        public void VTkapat()
        {
            baglanti.Close();
        }
        public void GuncelleAdet()
        {
            VTbaglan();
            string sorgu = "UPDATE tblDemirbas SET Adet=@adet WHERE DemirbasID=@demirbasID ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adet", (stok-Alinanadet));
            komut.Parameters.AddWithValue("@demirbasID", demirbasID);
            komut.ExecuteNonQuery();
            VTkapat();
        }
        public void dgwOdaDoldur()
        {
            VTbaglan();
            da = new SqlDataAdapter("SELECT O.OdaID,OdaAdi,ODT.PersonelID,PersonelAdi,PersonelSoyadi FROM tblOda O INNER JOIN tblOdaDemirbasAtama ODT ON O.OdaID=ODT.OdaID INNER JOIN tblPersonel P ON ODT.PersonelID=P.PersonelID", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblOda");
            dgwOdalar.DataSource = ds.Tables["tblOda"];
            VTkapat();
        }
        public void dgwDemirbasDoldur()
        {
            VTbaglan();
            da1 = new SqlDataAdapter("SELECT DemirbasID,DemirbasAdi,Fiyat,Adet FROM tblDemirbas", baglanti);
            ds1 = new DataSet();
            da1.Fill(ds1, "tblDemirbas");
            dgwDemirbas.DataSource = ds1.Tables["tblDemirbas"];
            VTkapat();
        }
        public void dgwOdaSecimiDoldur()
        {
            VTbaglan();
            da2 = new SqlDataAdapter("SELECT D.DemirbasID,DemirbasAdi,AlinanAdet FROM tblOdaDemirbasAtama ODT INNER JOIN tblDemirbas D ON ODT.DemirbasID=D.DemirbasID INNER JOIN tblOda O ON ODT.OdaID=O.OdaID WHERE ODT.OdaID= '"+ odaID.ToString() +"'", baglanti);
            ds2 = new DataSet();
            da2.Fill(ds2, "tblOdaDemirbasAtama");
            dgwDemirbasListesi.DataSource = ds2.Tables["tblOdaDemirbasAtama"];
            VTkapat();
        }

        private void frmDemirbasIslem_Load(object sender, EventArgs e)
        {
            dgwOdalar.AllowUserToAddRows = false;
            dgwDemirbas.AllowUserToAddRows = false;
            dgwOdaDoldur();
            dgwDemirbasDoldur();
            dgwOdaSecimiDoldur();          
        }
        int Alinanadet,stok;
        private void btnDemirbasIslemKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDIAdet.Text.Trim() == "") errorProvider1.SetError(txtDIAdet, "Boş geçilmez");
                else errorProvider1.SetError(txtDIAdet, "");
                if (txtDIAdet.Text.Trim() != "")
                {
                    Alinanadet = int.Parse(txtDIAdet.Text);
                    if (Alinanadet > stok)
                    {
                        MessageBox.Show("Girilen değer stok miktarından fazla.Daha az bir değer giriniz...");
                    }
                    else
                    {
                        VTbaglan();
                        komut = new SqlCommand("insert into tblOdaDemirbasAtama(OdaID,DemirbasID,AlinanAdet,PersonelID)values(@odaID,@demirbasID,@alinanAdet,@personelID)", baglanti);
                        komut.Parameters.AddWithValue("@odaID", odaID);
                        komut.Parameters.AddWithValue("@demirbasID", demirbasID);
                        komut.Parameters.AddWithValue("@alinanAdet", Alinanadet);
                        komut.Parameters.AddWithValue("@personelID", personelID);
                        komut.ExecuteNonQuery();
                        GuncelleAdet();
                        dgwDemirbasDoldur();
                        dgwOdaSecimiDoldur();
                        VTkapat();
                        MessageBox.Show("Odaya Demirbaş Atandı...");
                        txtDIAdet.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem Yaptınız.Tekrar deneyiniz...");
            }
        }

        private void btnDemirbasBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void dgwOdalar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOdaAdi.Text = ds.Tables["tblOda"].Rows[e.RowIndex]["OdaAdi"].ToString();
            odaID = ds.Tables["tblOda"].Rows[e.RowIndex]["OdaID"].ToString();
            personelID = ds.Tables["tblOda"].Rows[e.RowIndex]["PersonelID"].ToString();
            dgwOdaSecimiDoldur();
        }

        private void dgwDemirbas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDemirbasAdi.Text = ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasAdi"].ToString();
            demirbasID = ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasID"].ToString();
            stok = Convert.ToInt32(ds1.Tables["tblDemirbas"].Rows[e.RowIndex]["Adet"]);
        }

        private void txtDIAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
