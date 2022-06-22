using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ConnectionClass
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-IHCS472\SQLEXPRESS;Initial Catalog=DbMvcStok2;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
