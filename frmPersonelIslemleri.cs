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
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Cpersonel cp = new Cpersonel();
            CpersonelGorev cpg = new CpersonelGorev();
            string gorev = cpg.personelGorevTanim(Cgenel._gorevId);
            cp.personelBilgileriniGetirLV(lwPersoneller);

            if (gorev=="Müdür")
            {
                cp.personelBilgileriniGetir(cbPersoneller);
                cpg.personelGorevGetir(cbGorevPersonel);

           /*   btnYeniPersonel.Enabled = true;
                btnPerGuncelle.Enabled = false;
                groupBoxP1.Visible = true;
                groupBoxP2.Visible = false;
                groupBoxP3.Visible = false;
                txtPerSifre.ReadOnly = true;
                txtPerYeniSifre.ReadOnly = true;*/
                labelPersonel.Text = "Mevki: Müdür / Kullanıcı:" + cp.perBilgiAdGetirT(Cgenel._personelId);

            }

            else
            {
            //    groupBoxP1.Visible = false;
        //        groupBoxP2.Visible = false;
         //       groupBoxP3.Visible = true;
                labelPersonel.Text="Mevki: Personel / Kullanıcı:" + cp.perBilgiAdGetirT(Cgenel._personelId);
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnMasalarCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbGorevPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CpersonelGorev c = (CpersonelGorev)cbGorevPersonel.SelectedItem;
            txtGorevID.Text = Convert.ToString(c.PersonelGorevID);
            //orta grupboxtaki
        }

        private void cbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cpersonel c = (Cpersonel)cbPersoneller.SelectedItem;
            txtPersonelID.Text = Convert.ToString(c.PersonelId);
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (txtPerSifre.Text.Trim() != "" || txtPerYeniSifre.Text.Trim() != "")
            {

                if (txtPerSifre.Text == txtPerYeniSifre.Text)
                {
                    if (txtPersonelID.Text != "")
                    {
                        Cpersonel c = new Cpersonel();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelID.Text), txtPerYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşleminiz Başarı ile Tanımlandı...");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Personel Seçiniz !");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil!!");
                }
            }
            else
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız!!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        { //& KULLANDIM
            if(txtPersonelAd.Text.Trim() !="" || txtPersonelSoyad.Text.Trim() !="" || txtPersonelSifre.Text.Trim() !="" || txtGorevID.Text.Trim() !="")
            {
                if(txtPersonelSifre.Text.Trim()==txtPersonelSifreT.Text.Trim())
                {
                    Cpersonel c = new Cpersonel();
                    c.PersonelAd = txtPersonelAd.Text.Trim();
                    c.PersonelSoyad = txtPersonelSoyad.Text.Trim();
                    c.PersonelParola = txtPersonelSifreT.Text;
                    c.GorevId = Convert.ToInt32(txtGorevID.Text);
                    bool sonuc=c.personelEkle(c);

                    if(sonuc)
                    {
                        MessageBox.Show("Kayıt başarı ile eklenmiştir.");
                    }

                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi.");
                    }


                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil...");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
        }

        private void btnPerGuncelle_Click(object sender, EventArgs e)
        {
            if (lwPersoneller.SelectedItems.Count > 0) //seçili listview varsa
            {
                if (txtPersonelAd.Text != "" || txtPersonelSoyad.Text != "" || txtPersonelSifre.Text != "" || txtGorevID.Text != "")
                {
                    if (txtPersonelSifre.Text.Trim() == txtPersonelSifreT.Text.Trim())
                    {
                        Cpersonel c = new Cpersonel();
                        c.PersonelAd = txtPersonelAd.Text.Trim();
                        c.PersonelSoyad = txtPersonelSoyad.Text.Trim();
                        c.PersonelParola = txtPersonelSifreT.Text;
                        c.GorevId = Convert.ToInt32(txtGorevID.Text);
                        bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelID.Text)); //???????????

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt başarı ile güncellenmiştir.");
                            c.personelBilgileriniGetirLV(lwPersoneller);
                        }

                        else
                        {
                            MessageBox.Show("Kayıt güncellenemedi.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Şifreler aynı değil...");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                }
            }

            else
            {
                MessageBox.Show("Lütfen kayıt seçiniz !");
            }

        }

        private void lwPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lwPersoneller.SelectedItems.Count>0)
            {
                txtPersonelID.Text = lwPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevPersonel.SelectedIndex = Convert.ToInt32(lwPersoneller.SelectedItems[0].SubItems[1].Text)-1;
                txtPersonelAd.Text = lwPersoneller.SelectedItems[0].SubItems[3].Text;
                txtPersonelSoyad.Text = lwPersoneller.SelectedItems[0].SubItems[4].Text;
            }

        }
    }
    }

