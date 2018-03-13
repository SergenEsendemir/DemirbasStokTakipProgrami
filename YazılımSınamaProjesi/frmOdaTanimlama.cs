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
    public partial class frmOdaTanimlama : Form
    {
        public frmOdaTanimlama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds,ds1;
        SqlDataAdapter da,da1;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }
        private void btnTanimlamaBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
            
        }

        private void frmOdaTanimlama_Load(object sender, EventArgs e)
        {
            dGWOda.AllowUserToAddRows = false;
            dGWPersonel.AllowUserToAddRows = false;
            VTbaglan();
            da = new SqlDataAdapter("SELECT OdaID,OdaAdi FROM tblOda", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblOda");
            dGWOda.DataSource = ds.Tables["tblOda"];
            VTkapat();

            VTbaglan();
            da1 = new SqlDataAdapter("SELECT PersonelID,PersonelAdi,PersonelSoyadi FROM tblPersonel", baglanti);
            ds1 = new DataSet();
            da1.Fill(ds1, "tblPersonel");
            dGWPersonel.DataSource = ds1.Tables["tblPersonel"];
            VTkapat();
        }
        string Personelid,Odaid;    

        private void btnOTodaKaydet_Click(object sender, EventArgs e)
        {
            VTbaglan();
            komut = new SqlCommand("insert into tblOdaDemirbasAtama(OdaID,PersonelID)values(@odaID,@personelID)", baglanti);
            komut.Parameters.AddWithValue("@odaID", Odaid);
            komut.Parameters.AddWithValue("@personelID", Personelid);
            komut.ExecuteNonQuery();
            VTkapat();
            MessageBox.Show("Oda Sorumluya Atandı.");
        }

        private void dGWOda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOTodaAdi.Text=ds.Tables["tblOda"].Rows[e.RowIndex]["OdaAdi"].ToString();
            Odaid = ds.Tables["tblOda"].Rows[e.RowIndex]["OdaID"].ToString();
        }

        private void dGWPersonel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOTOdaSorumlusu.Text = ds1.Tables["tblPersonel"].Rows[e.RowIndex]["PersonelAdi"].ToString();
            Personelid = ds1.Tables["tblPersonel"].Rows[e.RowIndex]["PersonelID"].ToString();
        }     
    }
}
