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
    public partial class frmStokGuncelleme : Form
    {
        public frmStokGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlDataReader dr;
        string id;

        public void HarfGirisiKontrol(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SayiGirisiKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void GridDoldur()
        {
            DGWStokGuncelleme.AllowUserToAddRows = false;
            VTbaglan();
            da = new SqlDataAdapter("SELECT DemirbasID,DemirbasAdi,D.DemirbasTuruID,DemirbasTuruAdi,Fiyat,Adet,AlimTarihi FROM tblDemirbas D INNER JOIN tblDemirbasTurleri DT ON D.DemirbasTuruID=DT.DemirbasTuruID", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblDemirbas");
            DGWStokGuncelleme.DataSource = ds.Tables["tblDemirbas"];
            VTkapat();
        }
        private void frmStokGuncelleme_Load(object sender, EventArgs e)
        {

            GridDoldur();
            VTbaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblDemirbasTurleri";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;          
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lboxSGDemirbasTuruID.Items.Add(dr["DemirbasTuruID"]);
                lboxSGDemirbasTuruAdi.Items.Add(dr["DemirbasTuruAdi"]);
            }
            VTkapat();
        }
        private void btnSGguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSGdemirbasAdi.Text.Trim() == "") errorProvider1.SetError(txtSGdemirbasAdi, "Boş geçilmez");
                else errorProvider1.SetError(txtSGdemirbasAdi, "");
                if (txtSGfiyat.Text.Trim() == "") errorProvider1.SetError(txtSGfiyat, "Boş geçilmez");
                else errorProvider1.SetError(txtSGfiyat, "");
                if (txtSGadet.Text.Trim() == "") errorProvider1.SetError(txtSGadet, "Boş geçilmez");
                else errorProvider1.SetError(txtSGadet, "");
                if (txtSGdemirbasAdi.Text.Trim() != "" && txtSGfiyat.Text.Trim() != "" && txtSGadet.Text.Trim() != "")
                {

                    VTbaglan();
                    string sorgu = "UPDATE tblDemirbas SET DemirbasAdi=@demirbasAdi, Fiyat=@fiyat, AlimTarihi=@alimtarihi,Adet=@adet,DemirbasTuruID=@demirbasTuruID WHERE DemirbasID=@demirbasID ";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@demirbasAdi", txtSGdemirbasAdi.Text);
                    komut.Parameters.AddWithValue("@fiyat", txtSGfiyat.Text);
                    komut.Parameters.AddWithValue("@alimtarihi", DtmSGAlimTarihi.Value);
                    komut.Parameters.AddWithValue("@adet", txtSGadet.Text);
                    komut.Parameters.AddWithValue("@demirbasTuruID", txtSGDemirbasTuruID.Text);
                    komut.Parameters.AddWithValue("@demirbasID", id);
                    komut.ExecuteNonQuery();
                    VTkapat();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi.");
                    GridDoldur();
                }
            }
            catch
            {
                MessageBox.Show("Güncellerken hata oluştu.Lütfen tekrar deneyiniz...");
            }
        }
        private void btnStokGuncellemeBack_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void DGWStokGuncelleme_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = ds.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasID"].ToString();
            txtSGdemirbasAdi.Text = ds.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasAdi"].ToString();
            txtSGfiyat.Text = ds.Tables["tblDemirbas"].Rows[e.RowIndex]["Fiyat"].ToString();
            DtmSGAlimTarihi.Value = Convert.ToDateTime(ds.Tables["tblDemirbas"].Rows[e.RowIndex]["AlimTarihi"]);
            txtSGadet.Text = ds.Tables["tblDemirbas"].Rows[e.RowIndex]["Adet"].ToString();
            txtSGDemirbasTuruID.Text = ds.Tables["tblDemirbas"].Rows[e.RowIndex]["DemirbasTuruID"].ToString();
        }

        private void lboxSGDemirbasTuruID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSGDemirbasTuruID.Text = lboxSGDemirbasTuruID.SelectedItem.ToString();
        }

        private void txtSGdemirbasAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            HarfGirisiKontrol(e);
        }

        private void txtSGfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            SayiGirisiKontrol(e);
        }

        private void txtSGadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            SayiGirisiKontrol(e);
        }

       

        
    }
}
