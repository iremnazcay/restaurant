using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurant
{
    class Codeme
    {
        Cgenel gn1 = new Cgenel();
        #region Fields
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion

        #region Properties
        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal KdvTutari { get => _KdvTutari; set => _KdvTutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        #endregion

        //müşterinin masa hesabını kapat.
        public bool HesapKapat(Codeme odeme)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Insert into hesapOdemeleri(adisyonID, odemeTurID, musteriID, araToplam, kdvTutar, indirim, toplamTutar) values (@AdisyonId, @OdemeTurId, @MusteriId, @AraToplam, @KdvTutar, @Indirim, @ToplamTutar)",conn);
            try
            {
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.Add("AdisyonId", SqlDbType.Int).Value = odeme._AdisyonID;
                cmd.Parameters.Add("OdemeTurId", SqlDbType.Int).Value = odeme._OdemeTurId;
                cmd.Parameters.Add("MusteriId", SqlDbType.Int).Value = odeme._MusteriId;
                cmd.Parameters.Add("AraToplam", SqlDbType.Money).Value = odeme._AraToplam;
                cmd.Parameters.Add("KdvTutar", SqlDbType.Money).Value = odeme._KdvTutari;
                cmd.Parameters.Add("Indirim", SqlDbType.Money).Value = odeme._Indirim;
                cmd.Parameters.Add("ToplamTutar", SqlDbType.Money).Value = odeme._GenelToplam;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
            return sonuc;
        } 

        //müşterinin toplam harcamasını buluyoruz.
        public decimal sumTotalMusteriID(int musteriID)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection();
            //as le yeni ad veriyorum.
            SqlCommand cmd = new SqlCommand("Select sum(toplamTutar) as total from hesapOdemeleri where musteriID=@MusteriId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("MusteriId", SqlDbType.Int).Value = musteriID;

            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return total;
        }
    }
}
