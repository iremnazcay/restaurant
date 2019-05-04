using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace restaurant
{
    class Cadisyon
    {
        Cgenel gn1 = new Cgenel();

        #region Field
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar; //ek olarak yazdım veritabanınmda yok.
        private DateTime _Tarih;
        private int _Durum;
        private int _MasaID;
        private int _PersonelID;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaID { get => _MasaID; set => _MasaID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; } 
        #endregion

        public int getByAddition(int MasaID)  //açık olan masanın adisyon numarası.
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from adisyonlar where masaID=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaID;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaID = Convert.ToInt32(cmd.ExecuteScalar()); //scalar tek değer atar
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
                con.Close();
            }
            return MasaID;
        }
        public bool setByAddition(Cadisyon Bilgiler) //yeni adisyon açılıyor sql e ekliyoruz.
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("insert into adisyonlar(servisTurNo,tarih,personelID,masaID,durum) values(@ServisTurNo,@Tarih,@PersonelID,@MasaID,@Durum)", con);

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelID;
                cmd.Parameters.Add("@MasaID", SqlDbType.Int).Value = Bilgiler.MasaID;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 1;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }

            catch(SqlException ex)
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
        public void adisyonKapat(int adisyonId,int durum)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update adisyonlar set durum=@Durum where ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = durum;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = adisyonId;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            
        }
    }
}
