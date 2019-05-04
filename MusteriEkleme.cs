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
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }

        private void btnMusteriEkleYeniMus_Click(object sender, EventArgs e)
        {
            if (txtMusteriEkleTel.Text.Length > 6)
            {
                if (txtMusteriEkleAd.Text == ""  || txtMusteriEkleSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Ad ve Soyad Alanlarını doldurunuz");
                }
                else
                {
                    Cmusteriler c = new Cmusteriler();
                    bool sonuc = c.MusteriVarmi(txtMusteriEkleTel.Text);
                    if(!sonuc) //sonuc true değilse. Musteri yoksa
                    {
                        c.MusteriAd = txtMusteriEkleAd.Text;
                        c.MusteriSoyad = txtMusteriEkleSoyad.Text;
                        c.Telefon = txtMusteriEkleTel.Text;
                        c.Email = txtMusteriEkleEmail.Text;
                        c.Adres = txtMusteriEkleAdres.Text;

                       txtMusteriEkleMusteriID.Text=c.musteriEkle(c).ToString();
                        //selectle getirdiğim şey ID değerimdi scope la döndürdüm şimdide bunu görünmez olsun istediğim textboxa yazdım.

                    if(txtMusteriEkleMusteriID.Text!="")
                        {
                            MessageBox.Show("Müşteri Eklendi !");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Eklenemedi !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kayıt var !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz !");
            }
        }

        private void btnMusteriGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        private void btnMusteriCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            //Müşterilerimi güncelle dedim textboxtakileri alcak gelcek.
            if(Cgenel._musteriID>0)
            {
                Cmusteriler c = new Cmusteriler();
                txtMusteriEkleMusteriID.Text = Cgenel._musteriID.ToString();
                c.musterilerileriDoldur(Convert.ToInt32(Cgenel._musteriID),txtMusteriEkleAd,txtMusteriEkleSoyad,txtMusteriEkleAdres, txtMusteriEkleTel, txtMusteriEkleEmail);
            }

        }

        private void btnMusteriEkleMusteriGüncelle_Click(object sender, EventArgs e)
        {
            if(txtMusteriEkleTel.Text.Length>6)
            {
                if(txtMusteriEkleAd.Text=="" || txtMusteriEkleSoyad.Text=="")
                {
                    MessageBox.Show("Lütfen müşterinin ad ve soyad alanlarını doldurunuz.");
                }
                else
                {
                    Cmusteriler c = new Cmusteriler();
                    c.MusteriAd = txtMusteriEkleAd.Text;
                    c.MusteriSoyad = txtMusteriEkleSoyad.Text;
                    c.Adres = txtMusteriEkleAdres.Text;
                    c.Telefon = txtMusteriEkleTel.Text;
                    c.Email = txtMusteriEkleEmail.Text;
                    c.MusteriId = Convert.ToInt32(txtMusteriEkleMusteriID.Text); 
                    bool sonuc = c.musteriBilgileriGuncelle(c);

                    if (!sonuc)
                    {
                        MessageBox.Show("Bu isimde kayıt bulunamadı.");
                    }
                    else
                    {
                        if (txtMusteriEkleMusteriID.Text != "")
                        {
                            MessageBox.Show("Müşteri Güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri Güncellenemedi.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon giriniz.");
            }
        }
    }
}
