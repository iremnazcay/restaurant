using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace restaurant
{
    class Cmasalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;

        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTuru { get => _ServisTuru; set => _ServisTuru = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        #endregion

        Cgenel gn1 = new Cgenel();

        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select tarih,masaID from adisyonlar right join masalar on adisyonlar.masaID=masalar.ID where masalar.durum=@durum and adisyonlar.durum=0 and masalar.ID=@masaId",con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId); ;
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    dt = Convert.ToDateTime(dr["tarih"]).ToString();
                }
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Close();
                con.Close();
            }
            return dt;
        }

        public int MasaNumarasınıAl(string MasaValue)
        {
            string aa = MasaValue;
            int length = aa.Length;

            //masa 1 6 karekter 1 eksiğinden sonrasını yani 1 i al
            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }
        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result=false;
            SqlConnection conn = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select durum from masalar where ID=@TableId and durum=@State", conn);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@State", SqlDbType.Int).Value = state;

            try
            {
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
                conn.Dispose();
                conn.Close();
            }
            return result;
        }
        public void MasaDurumunuDegistir(string ButtonName, int durum)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update masalar set durum=@Durum where ID=@MasaNo", con);
            //ID imdeki durumu değiştir. doldu yapıcak 

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }

            string aa=ButtonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = durum;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
