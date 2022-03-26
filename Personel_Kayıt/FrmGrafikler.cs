using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayıt
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
       
        SqlConnection _baglanti = new SqlConnection(
           "Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");


        private void FrmGrafikler_Load_1(object sender, EventArgs e)
        {
            // CHART 1
            _baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("select PerSehir,Count(*) from Tbl_Personel Group By PerSehir", _baglanti);
            SqlDataReader rdr1 = kmt1.ExecuteReader();
            while (rdr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(rdr1[0], rdr1[1]);
            }

            _baglanti.Close();

            //CHART 2
            _baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("select PerMeslek,Avg(PerMaas) from Tbl_Personel Group By PerMeslek", _baglanti);
            SqlDataReader rdr2 = kmt2.ExecuteReader();
            while (rdr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(rdr2[0], rdr2[1]);
            }

            _baglanti.Close();
        }
    }
}
