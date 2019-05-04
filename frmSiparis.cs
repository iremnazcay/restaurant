using System;
using System.Collections;
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
    public partial class frmSiparisler : Form
    {
        public frmSiparisler()
        {
            InitializeComponent();
        }

        private void btnMasalarCıkıs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        //hesap mak.
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı Gir");
                    break;
            }
        }

        int tableID;
        int AdditionId;
        //Hesap İşlemleri
        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            lblMasa.Text = Cgenel._ButtonValue;

            Cmasalar ms = new Cmasalar();
            tableID = ms.MasaNumarasınıAl(Cgenel._ButtonName); //mesela btnMasa1 gibi
            
            if(ms.TableGetbyState(tableID,2)==true || ms.TableGetbyState(tableID, 4) == true)
            {
                Cadisyon adis = new Cadisyon();
                AdditionId = adis.getByAddition(tableID); //Doğru geliyor adisyon ID
                Csiparis orders = new Csiparis();
                orders.getByOrder(lwSiparisler, AdditionId);
            }


            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }

        CurunCesitleri uc = new CurunCesitleri();
        private void btnAnaYemek1_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnAnaYemek1);
        }

        private void btnCorba2_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnCorba2);
        }

        private void btnFasfood3_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnFasfood3);
        }

        private void btnSalata4_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnSalata4);
        }

        private void btnTatlılar5_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnTatlılar5);
        }

        private void btnIcecekler6_Click(object sender, EventArgs e)
        {
            uc.getByProductTypes(lwMenu, btnIcecekler6);
        }

        int sayac = 0; int sayac2 = 0;
        private void lwMenu_DoubleClick(object sender, EventArgs e)
        {
            //Seçilen nesneye çift tıklama

            if(txtAdet.Text=="")
            {
                txtAdet.Text = "1";
            }
            if(lwMenu.Items.Count>0)
            {
                sayac = lwSiparisler.Items.Count;
                lwSiparisler.Items.Add(lwMenu.SelectedItems[0].Text);
                lwSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);
                lwSiparisler.Items[sayac].SubItems.Add(lwMenu.SelectedItems[0].SubItems[2].Text);
                lwSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lwMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());
                lwSiparisler.Items[sayac].SubItems.Add("0");

                sayac2 = lwYeniEklenenler.Items.Count;
                lwSiparisler.Items[sayac].SubItems.Add(sayac.ToString());

                lwYeniEklenenler.Items.Add(AdditionId.ToString());
                lwYeniEklenenler.Items[sayac2].SubItems.Add(lwMenu.SelectedItems[0].SubItems[2].Text);
                lwYeniEklenenler.Items[sayac2].SubItems.Add(txtAdet.Text);
                lwYeniEklenenler.Items[sayac2].SubItems.Add(tableID.ToString());
                lwYeniEklenenler.Items[sayac2].SubItems.Add(sayac2.ToString());

                sayac2++;

                txtAdet.Text = "";
            }
        }

        ArrayList silinenler = new ArrayList();
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            /*
             1-Masa Boş
             2-Masa Dolu
             3-Masa Rezerve
             4-açık rezerve
             */

            Cmasalar masa = new Cmasalar();
            Cadisyon newAddition = new Cadisyon();
            Csiparis siparisKaydet = new Csiparis();
            frmMasa ms = new frmMasa();
            bool sonuc = false;

            //masa boşsa
            if (masa.TableGetbyState(tableID, 1) == true)
            {
                newAddition.ServisTurNo = 1;
                newAddition.PersonelID = 1;
                newAddition.MasaID = tableID;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAddition(newAddition);
                //masam artık açık oluyor.
                masa.MasaDurumunuDegistir(Cgenel._ButtonName, 2); //son uzunluktan numarayı bulucam.

                if (lwSiparisler.Items.Count > 0) //doluysa bilgileri getir.
                {
                    for (int i = 0; i < lwSiparisler.Items.Count; i++)
                    {
                        siparisKaydet.MasaId = tableID;
                        siparisKaydet.UrunId = Convert.ToInt32(lwSiparisler.Items[i].SubItems[2].Text); //(0,2)satır sütün listviewdeki
                        siparisKaydet.AdisyonId = newAddition.getByAddition(tableID);
                        siparisKaydet.Adet = Convert.ToInt32(lwSiparisler.Items[i].SubItems[1].Text);
                        siparisKaydet.setSaveOrder(siparisKaydet); //Bilgilerimi gönderiyorum.

                    }

                    this.Close();
                    ms.Show();
                }
            }
            
            //masa doluysa
            else if (masa.TableGetbyState(tableID, 2) == true)
            { //masa doluysa ve yeni eklemek istediği varsa
                if(lwYeniEklenenler.Items.Count > 0)
                {
                    for(int i=0; i< lwYeniEklenenler.Items.Count; i++)
                    {
                        siparisKaydet.MasaId = tableID;
                        siparisKaydet.UrunId = Convert.ToInt32(lwYeniEklenenler.Items[i].SubItems[1].Text);
                        siparisKaydet.AdisyonId = newAddition.getByAddition(tableID); //getbyadisyon adisyon ıd getirir
                        siparisKaydet.Adet = Convert.ToInt32(lwYeniEklenenler.Items[i].SubItems[2].Text);
                        siparisKaydet.setSaveOrder(siparisKaydet);
                    }
                   
                }
                
                if(silinenler.Count>0) 
                {
                    for(int i=0; i<lwYeniEklenenler.Items.Count; i++)
                    {
                        foreach(string item in silinenler)
                        {
                            siparisKaydet.setDeleteOrder(Convert.ToInt32(item));
                        }
                    }
                }

                this.Close();
                ms.Show();
            }
            //masa rezerve ise
            else if (masa.TableGetbyState(tableID, 3) == true) 
            {
                newAddition.ServisTurNo = 1;
                newAddition.PersonelID = 1;
                newAddition.MasaID = tableID;
                newAddition.Tarih = DateTime.Now;
                sonuc = newAddition.setByAddition(newAddition); //yeni sql e adisyon açıyor.
                //masam artık açık oluyor.
                masa.MasaDurumunuDegistir(Cgenel._ButtonName, 4); //son uzunluktan numarayı bulucam.

                if (lwSiparisler.Items.Count > 0) //doluysa bilgileri getir.
                {
                    for (int i = 0; i < lwSiparisler.Items.Count; i++) //
                    {
                        siparisKaydet.MasaId = tableID;
                        siparisKaydet.UrunId = Convert.ToInt32(lwSiparisler.Items[i].SubItems[2].Text); //(0,2)satır sütün listviewdeki
                        siparisKaydet.AdisyonId = newAddition.getByAddition(tableID);
                        siparisKaydet.Adet = Convert.ToInt32(lwSiparisler.Items[i].SubItems[1].Text);
                        siparisKaydet.setSaveOrder(siparisKaydet); //Bilgilerimi gönderiyorum.

                    }

                    this.Close();
                    ms.Show();
                }
            }
        }

        private void lwSiparisler_DoubleClick(object sender, EventArgs e)
        {
            if (lwSiparisler.Items.Count > 0) //lwSiparişlerde ürün var mı bakıyor ve buraya giriyor.
            {
              if (lwSiparisler.SelectedItems[0].SubItems[4].Text != "0")
                {
                    Csiparis kayit = new Csiparis();
                    kayit.setDeleteOrder(Convert.ToInt32(lwSiparisler.SelectedItems[0].SubItems[4].Text)); //satıs ID siliyorum
                }
                else //Silme işlemimi sipariş vermede önce yapıyorsam
                {
                    for (int i = 0; i < lwYeniEklenenler.Items.Count; i++)
                    {
                        if (lwYeniEklenenler.Items[i].SubItems[4].Text == lwSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lwYeniEklenenler.Items.RemoveAt(i);
                        }
                    }
                }

                lwSiparisler.Items.RemoveAt(lwSiparisler.SelectedItems[0].Index);
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Cgenel._ServisTurNo = 1;
            Cgenel._AdisyonID = AdditionId.ToString();
            frmOdeme frm = new frmOdeme();
            this.Close();
            frm.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
    }
}
