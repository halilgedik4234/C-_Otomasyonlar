using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NeT_Final_Calısması
{
    public class ProductDal
    {

        public DataTable GetAll()
        {
            SqlConnection _baglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Final_Calismasi; integrated security=true");

            if (_baglanti.State==ConnectionState.Closed)
            {
                _baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("Select * From Final_Calismasi_Tablosu", _baglanti);
            
            SqlDataReader reader=komut.ExecuteReader();
             
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            _baglanti.Close();
            return data;

        }

    }
}
