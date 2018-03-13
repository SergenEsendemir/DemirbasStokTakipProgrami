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
using System.IO;

namespace YazılımSınamaProjesi
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;

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
                cmbRapor.SelectedItem = null;
                cmbRapor.Items.Add(dr["OdaAdi"]);
            }
            VTkapat();
        }
        
        void RaporDoldur()
        {           
            string oda = cmbRapor.Text;
            VTbaglan();
            da = new SqlDataAdapter("SELECT O.OdaID,OdaAdi,ODT.PersonelID,PersonelAdi,PersonelSoyadi,ODT.DemirbasID,DemirbasAdi,Fiyat,AlimTarihi,AlinanAdet FROM tblOda O INNER JOIN tblOdaDemirbasAtama ODT ON O.OdaID=ODT.OdaID INNER JOIN tblPersonel P ON ODT.PersonelID=P.PersonelID INNER JOIN tblDemirbas D ON ODT.DemirbasID=D.DemirbasID WHERE OdaAdi='" + oda + "'", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblOda");
            dgwRapor.DataSource = ds.Tables["tblOda"];
            VTkapat();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {          
            ComboboxDoldur();
            cmbRapor.SelectedIndex = 0; 
            RaporDoldur();
            
        }
        private void btnRaporArama_Click(object sender, EventArgs e)
        {
            RaporDoldur();
        }

        private void btnAramalarBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void PDYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dgwRapor.Height;
                dgwRapor.Height = dgwRapor.RowCount * dgwRapor.RowTemplate.Height * 2;
                bmp = new Bitmap(dgwRapor.Width, dgwRapor.Height);
                dgwRapor.DrawToBitmap(bmp, new Rectangle(0, 0, dgwRapor.Width, dgwRapor.Height));
                dgwRapor.Height = height;
                PpdDialog.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }

        }
       
    }
}
