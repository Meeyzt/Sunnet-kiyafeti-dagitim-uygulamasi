using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace qweqwe
{
    class Class1
    {
        public DataTable dt ;
        public OleDbCommand komut;
        public OleDbConnection baglanti;
        public OleDbDataAdapter datada;
        public DataSet ds;
        public OleDbDataReader dr;
        // () ;

        public void baglantikur(string mevzu,string fil)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Sunnet2018.accdb");
            datada = new OleDbDataAdapter(mevzu, baglanti);
            ds = new DataSet();
            baglanti.Open();
            datada.Fill(ds, fil);

        }
        public void kaydet(string mevzu)
        {
            try
            {
                komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = mevzu;
               komut.ExecuteNonQuery();
                baglanti.Close();
                kaydettimi = true;
            }
            catch
            { kaydettimi = false; }
        }
        public void kontrol(string mevzu)
        {
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = mevzu;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                a = 0;
            }
            else
            {
                a = 1;
            }
        
            baglanti.Close();
        }
        public bool Varmi()
        {
            if (a == 0)
            {
                varmis = true;
            }
            else if (a == 1)
            {
                varmis = false;
            }
            return varmis;
        }
        public int a;
        public  bool kaydettimi,varmis;
       
    }
}
