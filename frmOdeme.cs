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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void btnMasalarCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        Csiparis cs = new Csiparis();
        private void frmOdeme_Load(object sender, EventArgs e)
        {
            if(Cgenel._ServisTurNo==1)
            {
                lbAdisyonID.Text = Cgenel._AdisyonID;
                txtIndirimUygula.TextChanged += new EventHandler(txtIndirimUygula_TextChanged);
                cs.getByOrder(lvUrunlerOdeme, Convert.ToInt32(lbAdisyonID.Text));
                if(lvUrunlerOdeme.Items.Count>0)
                {
                    decimal toplam = 0;
                    for(int i=0; i<lvUrunlerOdeme.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunlerOdeme.Items[i].SubItems[3].Text);
                    }
                    lbFiyat.Text = string.Format("{0:0.000}", toplam);
                    lbAraToplam.Text = String.Format("{0:0.000}", toplam);
                }

                txtIndirimUygula.Clear();
            }
        }

        private void txtIndirimUygula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDecimal(lbindirim.Text)<Convert.ToDecimal(lbFiyat.Text))
                {
                    try
                    {
                        lbindirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimUygula.Text));
                    }
                    catch(Exception)
                    {
                        lbindirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim tutarı toplam tutardan fazla olamaz !!");
                }
            }
            catch(Exception)
            {
                lbindirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void lbIndirim_TextChanged(object sender, EventArgs e)
        {

            decimal x = Convert.ToDecimal(lbindirim.Text);
            if (x > 0) 
            {
                decimal odenecek = 0;
                lbAraToplam.Text = lbFiyat.Text; //toplam tutar fiyat olan , odenecek kısımda ara toplam
                odenecek = Convert.ToDecimal(lbAraToplam.Text)-Convert.ToDecimal(lbindirim.Text);
                lbAraToplam.Text = string.Format("{0:0.000}", odenecek);

            }

            decimal kdv = Convert.ToDecimal(lbAraToplam.Text)*18/100;
            lbKDV.Text = string.Format("{0:0.000}", kdv);
            kdv = Convert.ToDecimal(lbAraToplam.Text) - Convert.ToDecimal(lbKDV.Text);
            lbAraToplam.Text = string.Format("{0:0.000}",kdv);
        }

        Cmasalar masalar = new Cmasalar();
        Crezervasyon rezerve = new Crezervasyon();
        Cadisyon adisyon = new Cadisyon();

        private void btnHesapKapa_Click(object sender, EventArgs e)
        {
            if (Cgenel._ServisTurNo == 1)
            {
                int masaID = masalar.MasaNumarasınıAl(Cgenel._ButtonName);
                int musteriID = 0;
           
                if(masalar.TableGetbyState(masaID,3)==true) //rezerve için 
                {
                    masaID = rezerve.getirMusteriIDFromRezervasyon(masaID);
                }

                else
                {
                    musteriID = 1;
                }
                int odemeTurId = 0;
                
                if(rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                if(rbKrediKartı.Checked)
                {
                    odemeTurId = 2;
                }

                Codeme odeme = new Codeme();

                odeme.AdisyonID = Convert.ToInt32(lbAdisyonID.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriID;
                odeme.AraToplam = Convert.ToDecimal(lbAraToplam.Text);
                odeme.KdvTutari = Convert.ToDecimal(lbKDV.Text);
                odeme.GenelToplam = Convert.ToDecimal(lbFiyat.Text);
                odeme.Indirim = Convert.ToDecimal(lbindirim.Text);

                bool result = odeme.HesapKapat(odeme);
                // formdaki verileri odeme clasım ile gönderdim sql de işledim.
                
            if(result)
                {
                    //masalardan durumu boş yap
                    masalar.MasaDurumunuDegistir(Convert.ToString(masaID), 1); //masa durumunu boş yaptım.
                    //rezervasyonda durumu kapadık yap
                    rezerve.rezervasyonKapat(Convert.ToInt32(lbAdisyonID.Text));
                    //adisyon kapat
                    adisyon.adisyonKapat(Convert.ToInt32(lbAdisyonID.Text),0);

                    MessageBox.Show("Hesap Kapatılmıştır !");
                    this.Close();
                    frmMasa frm = new frmMasa();
                    frm.Show();
                }

            else
                {
                    MessageBox.Show("Hesap Kapatılırken Hata Oluştu !!");
                }
            }

        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("İREM Restaurant", Baslik, sb, 250, 100, st);
            e.Graphics.DrawString("---------------------------", altBaslik, sb, 250, 120, st);
            e.Graphics.DrawString("Ürün Adı                 Adet                    Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("------------------------------------------------------------", altBaslik, sb, 150, 280, st);

            for (int i = 0; i <lvUrunlerOdeme.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunlerOdeme.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunlerOdeme.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunlerOdeme.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st); //2 ürünıd onu geçtim
                
            }

            e.Graphics.DrawString("------------------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunlerOdeme.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı :------------" +lbindirim.Text +" TL", altBaslik,sb,250,300+30*(lvUrunlerOdeme.Items.Count+1),st);
            e.Graphics.DrawString("KDV Tutarı :------------" + lbKDV.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunlerOdeme.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar :------------" + lbFiyat.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunlerOdeme.Items.Count + 3), st);
            e.Graphics.DrawString("Ödediğiniz Tutar :------------" + lbAraToplam.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunlerOdeme.Items.Count + 4), st);


        }
    }
}
