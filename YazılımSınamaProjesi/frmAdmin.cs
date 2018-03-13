using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımSınamaProjesi
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmanamenu = new frmAnaMenu(this);
            frmanamenu.Show();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            frmStokEkleme frmstokekleme = new frmStokEkleme();
            frmstokekleme.Show();
            this.Hide();
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            frmStokGuncelleme frmstokguncelleme = new frmStokGuncelleme();
            frmstokguncelleme.Show();
            this.Hide();
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            frmOdaSil frmOdaSil = new frmOdaSil();
            frmOdaSil.Show();
            this.Hide();
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            frmOdaEkle frmodaekle = new frmOdaEkle();
            frmodaekle.Show();
            this.Hide();
        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            frmOdaGuncelle frmOdaGuncelle = new frmOdaGuncelle();
            frmOdaGuncelle.Show();
            this.Hide();
        }
    }
}
