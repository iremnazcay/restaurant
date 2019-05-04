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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            Cpersonel p = new Cpersonel();
            p.personelBilgileriniGetir(cbKullanıcıAd); //benim oluşturduğum combobox
        }

        private void btnKullanıcıGiris_Click(object sender, EventArgs e)
        {
            Cgenel gn1 = new Cgenel();
            Cpersonel p = new Cpersonel();
            bool result = p.personelEntryControl(txtKullanıcıSifre.Text,Cgenel._personelId);

            if (result)
            {
                CpersonelHareketleri ch = new CpersonelHareketleri();
                ch.PersonelId = Cgenel._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelHareketleriKaydet(ch); //veri tabanına kaydediyor. //personel kısmında sıkıntı var


                this.Hide(); //doğruysa gizliyorum.
                frmMenu menu = new frmMenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Şifreniz Yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void btnKullanıcıCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?","Uyarı !!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbKullanıcıAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cpersonel p = (Cpersonel)cbKullanıcıAd.SelectedItem;
            Cgenel._personelId = p.PersonelId;
            Cgenel._gorevId = p.GorevId;
        }
    }
}
