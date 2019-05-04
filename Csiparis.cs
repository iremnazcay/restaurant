using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace restaurant
{
    class Csiparis
    {
        Cgenel gn1 = new Cgenel();
        #region Fields
        private int _Id;
        private int _adisyonId;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion

        #region Properties

        public int Id { get => _Id; set => _Id = value; }
        public int AdisyonId { get => _adisyonId; set => _adisyonId = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; } 
        #endregion
        
        public void getByOrder(ListView lv ,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select urunAdi,fiyat,satislar.ID,urunID,satislar.adet from satislar Inner Join urunler on satislar.urunID=urunler.ID where adisyonID=@AdisyonId", con);
            //her satışın bir adisyon ID si var.
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                int sayac = 0;
                while(dr.Read())
                {
                    lv.Items.Add(dr["urunAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["fiyat"])* Convert.ToDecimal(dr["adet"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }
            }
            
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
               // dr.Close(); ??????????? yazınca masa 2 doluya tıklayamıyordum.
                con.Dispose();
                con.Close();
            }
        }
        public bool setSaveOrder(Csiparis Bilgiler)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("insert into satislar(adisyonID,urunID,adet,masaID) values(@AdisyonNo,@UrunId,@Adet,@MasaId)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = Bilgiler._adisyonId;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler._masaId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._adet;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

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

            return sonuc;
        }
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Delete From satislar where ID=@SatisID",con);

            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = satisId;

            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }

    }
 }
