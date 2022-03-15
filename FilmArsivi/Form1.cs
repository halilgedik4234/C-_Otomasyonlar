using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-IHCS472\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        void Filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD, KATEGORİ, LINK, DURUM FROM TBLFILMLER ",_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }
    }
}
