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
    public partial class GİRİŞ_EKRANI : Form
    {
        public GİRİŞ_EKRANI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter sda;
        DataTable dt;
        public void VTbaglan()
        {
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=DemirbasTakip;Integrated Security=SSPI");
            baglanti.Open();
        }

        public void VTkapat()
        {
            baglanti.Close();
        }

        public static string kAdi,sifre;
        private void button1_Click(object sender, EventArgs e)
        {
                
                kAdi = txtUsername.Text;
               sifre = txtPassword.Text;                    
           try
            {
                VTbaglan();
                sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblKullanicilar WHERE KullaniciAdi='" + kAdi+ "' AND Sifre='" + sifre + "'", baglanti);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    frmAnaMenu anamenu = new frmAnaMenu(this);
                    anamenu.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.Lütfen tekrar giriniz!!!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Text = "KULLANICI ADI";
                    txtPassword.Text = "ŞİFRE";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            VTkapat();          

        }

        private void Form1_Click(object sender, EventArgs e)
        {  
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "KULLANICI ADI";
                txtUsername.SelectionStart = txtUsername.Text.Length;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "ŞİFRE";
                txtPassword.SelectionStart = txtPassword.Text.Length;

            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUsername.Text == "KULLANICI ADI")
            {
                errorProvider1.SetError(txtUsername, "Lütfen Kullanıcı Adınızı Giriniz");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text.ToString() == "ŞİFRE")
            {
                errorProvider1.SetError(txtPassword, "Bu alan boş geçilemez");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";           
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";            
        }
    }
}
