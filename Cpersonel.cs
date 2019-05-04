using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace restaurant
{
    class Cpersonel
    {
        Cgenel gn1 = new Cgenel();
        
        #region Field
        private int _PersonelId;
        private int _GorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _Durum;
        #endregion

        //Bunları özellik yapıyoruz. Gizlemiştik 

        #region Properties
        public int GorevId { get => _GorevId; set => _GorevId = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        #endregion
        //COMBOBOX
        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gn1.conString); //bağlandım
            SqlCommand cmd = new SqlCommand("Select * from personeller where ID=@Id and parola=@password", con);

            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
           {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result =Convert.ToBoolean(cmd.ExecuteScalar());
           }
            catch(SqlException ex)
            {
                string hata = ex.Message;
        
            }

            return result ;
        }
        public void personelBilgileriniGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString); //bağlandım
            SqlCommand cmd = new SqlCommand("Select * from personeller", con);
            
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cpersonel p = new Cpersonel();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._GorevId= Convert.ToInt32(dr["gorevID"]);
                p._PersonelAd = Convert.ToString(dr["ad"]);
                p._PersonelSoyad = Convert.ToString(dr["soyad"]);
                p._PersonelParola = Convert.ToString(dr["parola"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["kullaniciAdi"]);
                p._Durum = Convert.ToBoolean(dr["durum"]);



                cb.Items.Add(p); 
                //comboboxa birden fazla bilgileri atmak için sınıf gibi düşündüm.

            }
            dr.Close();
            con.Close();

        }
        public override string ToString() //override yaparak combobox içindeki istediğim stringi aldım.
        {
            return _PersonelAd +" "+ _PersonelSoyad;
        }

        //LİSTVİEW
        //personel ekle çıkar güncelle için alt fonksiyonları oluşturdum.
        public void personelBilgileriniGetirLV(ListView lw)
        {
            lw.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString); //bağlandım
            SqlCommand cmd = new SqlCommand("Select personeller.*, personelGorevleri.gorev from personeller inner join personelGorevleri on personelGorevleri.ID=personeller.gorevID where personeller.durum=1", con);
            //.* demek tablodaki bütün verileri getir..

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lw.Items.Add(dr["ID"].ToString());
                lw.Items[i].SubItems.Add(dr["gorevID"].ToString());
                lw.Items[i].SubItems.Add(dr["gorev"].ToString());
                lw.Items[i].SubItems.Add(dr["ad"].ToString());
                lw.Items[i].SubItems.Add(dr["soyad"].ToString());
                lw.Items[i].SubItems.Add(dr["kullaniciAdi"].ToString());
                i++;

            }
            dr.Close();
            con.Close();

        }
        public void personelBilgileriniGetirLVIDT(ListView lw, int perID)
        {
            lw.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString); //bağlandım
            SqlCommand cmd = new SqlCommand("Select personeller.*, personelGorevleri.gorev from personeller inner join personelGorevleri on personelGorevleri.ID=personeller.gorevID where personeller.durum=0 and personeller.ID=@perID", con);
            //.* demek tablodaki bütün verileri getir..
            cmd.Parameters.Add("@perID", SqlDbType.Int).Value = perID;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                lw.Items.Add(dr["ID"].ToString());
                lw.Items[i].SubItems.Add(dr["gorevID"].ToString());
                lw.Items[i].SubItems.Add(dr["gorev"].ToString());
                lw.Items[i].SubItems.Add(dr["ad"].ToString());
                lw.Items[i].SubItems.Add(dr["soyad"].ToString());
                lw.Items[i].SubItems.Add(dr["kullaniciAdi"].ToString());
                i++;

            }
            dr.Close();
            con.Close();

        }
        public string perBilgiAdGetirT(int perID)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select ad from personeller where durum=1 and ID=@perID", con);
            cmd.Parameters.Add("@perID", SqlDbType.Int).Value = perID;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar()); //scalarla yanlızca bir bilgi alabiliyorum.
            }
            catch(Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            con.Close();
            return sonuc;
        }


        //personel ekle
        public bool personelEkle(Cpersonel cp)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Insert into personeller(ad,soyad,parola,gorevID) Values(@ad,@soyad,@parola,@gorevID)", con);
            cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = cp._PersonelAd;
            cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = cp. _PersonelSoyad;
            cmd.Parameters.Add("@parola", SqlDbType.VarChar).Value = cp._PersonelParola;
            cmd.Parameters.Add("@gorevID", SqlDbType.Int).Value = cp. _GorevId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch(Exception ex)
            {
                string hata = ex.Message;
            }
            con.Close();

            return sonuc;
        }
        //personel güncelle
        public bool personelGuncelle(Cpersonel cp, int perID)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update personeller set ad=@Ad,soyad=@Soyad,parola=@Parola,gorevID=@GorevID,durum=@Durum where ID=@perID", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@perID", SqlDbType.Int).Value = perID;
                cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = cp._PersonelAd;
                cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = cp._PersonelSoyad;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar).Value = cp._PersonelParola;
                cmd.Parameters.Add("@GorevID", SqlDbType.Int).Value = cp._GorevId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 1;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            con.Close();

            return sonuc;
        }
        //personel şifre değiştir
        public bool personelSifreDegistir(int perID, string password)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Update personeller set parola=@parola where ID=@perID", con);
            cmd.Parameters.Add("@perID", SqlDbType.Int).Value = perID;
            cmd.Parameters.Add("@parola", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            con.Close();

            return sonuc;
        }
    }
    }
