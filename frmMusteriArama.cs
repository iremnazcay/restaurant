using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            Cmusteriler c = new Cmusteriler();
            c.musterileriGetir(lwMusteriler);
            //müşterileri getiricek.
        }
        private void btnMusteriCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMusteriGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {

            MusteriEkleme m = new MusteriEkleme();
            Cgenel._musteriEkleme = 0;
            m.Show();
            this.Close();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
               if (lwMusteriler.SelectedItems.Count>0)
               {
                   MusteriEkleme m = new MusteriEkleme();
                   //seçili müşteri varsa gel
                   Cgenel._musteriEkleme = 1;
                   Cgenel._musteriID =Convert.ToInt32(lwMusteriler.SelectedItems[0].SubItems[0].Text);

                   this.Close();
                   m.Show();
               }

        }
    }
}
