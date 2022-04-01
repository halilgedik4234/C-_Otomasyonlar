using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciBilgiSistemi
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IHCS472\SQLEXPRESS;Initial Catalog=TalebeBilgiSistemi;Integrated Security=True");
            con.Open();
            return con;
            
        }
    }
}
