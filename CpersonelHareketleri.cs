using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace restaurant
{
    class CpersonelHareketleri
    {
        Cgenel gn1 = new Cgenel();
        #region Field
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }

        #endregion

        public bool PersonelHareketleriKaydet(CpersonelHareketleri ph)
        {
            bool result=false;

            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Insert Into personelHareketlilik(personelID,islem,tarih) Values(@personelId,@islem,@tarih)", con); //@ile dışardan gelen olacağını belirtiyorum.

           try
           {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = ph.PersonelId;
                cmd.Parameters.Add("@islem", SqlDbType.VarChar).Value = ph._Islem;
                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = ph._Tarih;

                result =Convert.ToBoolean(cmd.ExecuteNonQuery());
           }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            return result;
        }
    }
}
