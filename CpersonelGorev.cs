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
    class CpersonelGorev
    {
        Cgenel gn1 = new Cgenel();
        #region Fields
        private int _personelGorevID;
        private string _tanim;
        #endregion
        #region Properties

        public int PersonelGorevID { get => _personelGorevID; set => _personelGorevID = value; }
        public string Tanim { get => _tanim; set => _tanim = value; } 
        #endregion

        public void personelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select * from personelGorevleri", con);
            SqlDataReader dr = null;
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    CpersonelGorev c = new CpersonelGorev();
                    c._personelGorevID = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = (dr["gorev"].ToString());
                    cb.Items.Add(c);
                    //combobox içersine classtan aldığım bütün bilgileri aktardım.
                }   
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }

        public string personelGorevTanim(int per)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gn1.conString);
            SqlCommand cmd = new SqlCommand("Select gorev from personelGorevleri where ID=@perID", con);

            cmd.Parameters.Add("@perID", SqlDbType.Int).Value = per;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            con.Close();

            return sonuc;
        }

        public override string ToString()
        {
            return _tanim;
        }

    }
}
