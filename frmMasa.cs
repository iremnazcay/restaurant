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

namespace restaurant
{
    public partial class frmMasa : Form
    {
        public frmMasa()
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

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa1.Text.Length;

            Cgenel._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık

        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa2.Text.Length;

            Cgenel._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık

        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa3.Text.Length;

            Cgenel._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa4.Text.Length;

            Cgenel._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa4.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa5.Text.Length;

            Cgenel._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa5.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa6.Text.Length;

            Cgenel._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa6.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa7.Text.Length;

            Cgenel._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa7.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa8.Text.Length;

            Cgenel._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa8.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparisler frm = new frmSiparisler();
            int uzunluk = btnMasa9.Text.Length;

            Cgenel._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6); //uzunluktan 6 karakter çıkar ve 6. karekterden başla.
            Cgenel._ButtonName = btnMasa9.Name;
            this.Close();
            frm.ShowDialog(); //sipariş kısmını açtık
        }

        Cgenel gn1 = new Cgenel();

        private void frmMasa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select durum,ID from masalar", con);
            SqlDataReader dr = null;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if(item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["durum"].ToString() == "1")
                        {
                            item.BackColor = Color.Green; //boş 
                        }

                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["durum"].ToString() == "2")
                        {
                            Cmasalar ms = new Cmasalar();
                           /* DateTime dt1 =DateTime.Parse(ms.SessionSum(2,dr["ID"].ToString())); //clasımdan dönen değeri aldım ??
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2, dr["ID"].ToString())).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;
                                item.Text = 
                                String.Format("{0}{1}{2}",
                                fark.Days > 0 ? string.Format("{0} gün", fark.Days): " ",
                                fark.Hours > 0 ? string.Format("{0} saat",fark.Hours): " ",
                                fark.Minutes > 0 ? string.Format("{0} dakika", fark.Minutes): " ").Trim() +"\nMasa"+ dr["ID"].ToString();*/

                            item.BackColor = Color.Red; //dolu
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["durum"].ToString() == "3")
                        {
                            item.BackColor = Color.Gold; //açık rezervasyon gelmiş
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["durum"].ToString() == "4")
                        {
                            item.BackColor = Color.Orange; //rezervasyon
                        }
                    }
                }
            }
        }

    }
}
