using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace restaurant
{
    class CurunCesitleri
    {
        Cgenel gn1 = new Cgenel();

        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion
        #region Properties

        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; } 
        #endregion

        public void getByProductTypes(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select urunAdi,fiyat,urunler.ID from kategoriler Inner Join urunler on kategoriler.ID=urunler.kategoriID where urunler.kategoriID=@kategoriID",conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@kategoriID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                cesitler.Items.Add(dr["urunAdi"].ToString());
                cesitler.Items[i].SubItems.Add(dr["fiyat"].ToString());
                cesitler.Items[i].SubItems.Add(dr["ID"].ToString());

                i++;

            }
            dr.Close();
            conn.Close();
            cmd.Clone();
        }

        public void urunleriGoster(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select * from urunler", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["acıklama"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["fiyat"].ToString());
                    sayac++;
                }
            }

            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
    }
}
