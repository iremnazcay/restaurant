using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurant
{
    class Crezervasyon
    {
        Cgenel gn1 = new Cgenel();
        #region Fields
        private int _ID;
        private int _TableId;
        private int _MusteriId;
        private DateTime _Date;
        private int _MusteriKisiSayisi;
        private string _Acıklama;
        private int _AdditionId;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _TableId; set => _TableId = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int MusteriKisiSayisi { get => _MusteriKisiSayisi; set => _MusteriKisiSayisi = value; }
        public string Acıklama { get => _Acıklama; set => _Acıklama = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; } 
        #endregion

        //müşteri ıd rezervasyon masa numarasına göre
        public int getirMusteriIDFromRezervasyon(int tableId)
        {
            int musteriNumaram = 0;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand("Select top 1 musteriID from rezervasyonlar where masaID=@masaId order by musteriID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("masaId", SqlDbType.Int).Value = tableId;

                musteriNumaram = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


            return musteriNumaram;
        }

        //Hesap kapatıldı rezervasyonlarla
        public bool rezervasyonKapat(int adisyonId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update rezervasyonlar set durum=0 where adisyonID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonId;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }
    }
}
