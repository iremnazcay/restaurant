using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace restaurant
{
    class Cmusteriler
    {
        Cgenel gn1 = new Cgenel();
        #region Fields
        private int _musteriId;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;
        private string _email;
        #endregion

        #region Properties
        public int MusteriId { get => _musteriId; set => _musteriId = value; }
        public string MusteriAd { get => _musteriAd; set => _musteriAd = value; }
        public string MusteriSoyad { get => _musteriSoyad; set => _musteriSoyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Adres { get => _adres; set => _adres = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion

        //stored prodecure kullandım
        public bool MusteriVarmi(string tlf)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi"; //komutu direk prosedura yolluyorum burda sorgu yazmıyorum.
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery(); //sorgumu çalıştır. Ve gelen parametreyi döndür
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return sonuc;
        }

        public int musteriEkle(Cmusteriler m)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Insert into musteriler (ad,soyad,adres,telefon,email) values(@ad,@soyad,@adres,@telefon,@email); select SCOPE_IDENTITY()", con);
            //SCOPE EKLEYECEĞİ YENİ MÜŞTERİ İÇİN KULLANMADIĞIM İLK ID Yİ BANA GETİRİCEK.

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return sonuc;
        }

        public bool musteriBilgileriGuncelle(Cmusteriler m)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update musteriler set ad=@Ad,soyad=@Soyad,adres=@Adres,telefon=@Telefon,email=@Email where ID=@MusteriID", con);

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = m._musteriAd;
                cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
                cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = m._email;
                cmd.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriId;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch(Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        //listview de görüntüleme
        public void musterileriGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select * from musteriler", con);

            SqlDataReader dr = null;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while(dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["email"].ToString());
                    sayac++;
                }
            }

            catch(Exception ex)
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

        //müşterileri id ye göre getir.Güncelle dedikten sonra textleri dolduruyorum.
        public void musterilerileriDoldur(int musteriId, TextBox ad, TextBox soyad, TextBox adres, TextBox telefon, TextBox email)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select * from musteriler where ID=@musteriID",con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("musteriID", SqlDbType.Int).Value = musteriId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    ad.Text = dr["ad"].ToString();
                    soyad.Text = dr["soyad"].ToString();
                    adres.Text = dr["adres"].ToString();
                    telefon.Text = dr["telefon"].ToString();
                    email.Text = dr["email"].ToString();

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
