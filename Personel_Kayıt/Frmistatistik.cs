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
    public partial class istatistikForm : Form
    {
        public istatistikForm()
        {
            InitializeComponent();
        }
        SqlConnection _baglanti = new SqlConnection(
           "Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void istatistikForm_Load(object sender, EventArgs e)
        {
            //TOPLAM PERSONEL SAYISI
            _baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count (*) from Tbl_Personel",_baglanti);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                LblToplamPersonel.Text = reader1[0].ToString();
            }

            _baglanti.Close();

            //EVLİ PERSONEL SAYISI
            _baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count (*) from Tbl_Personel where PerDurum=1", _baglanti);
            SqlDataReader reader2=komut2.ExecuteReader();               
            while (reader2.Read())
            {
                LblEvliPersonel.Text = reader2[0].ToString();
            }
            _baglanti.Close();

            //BEKAR PERSONEL SAYISI
            _baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count (*) from Tbl_personel where PerDurum=0",_baglanti);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                LblBekarPersonel.Text = reader3[0].ToString();
            }
            _baglanti.Close();

            //ŞEHİR SAYISI
            _baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel",_baglanti);
            SqlDataReader reader4=komut4.ExecuteReader();
            while (reader4.Read())
            {
                LblSehirSayisi.Text = reader4[0].ToString();
            }
            _baglanti.Close();

            // TOPLAM MAAŞ
            _baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from Tbl_Personel",_baglanti);
            SqlDataReader reader5 = komut5.ExecuteReader();
            while (reader5.Read())
            {
                LblToplamMaas.Text = reader5[0].ToString();
            }
            _baglanti.Close();

            // ORTALAMA MAAŞ
            _baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select Avg(PerMaas) from Tbl_Personel",_baglanti);
            SqlDataReader reader6=komut6.ExecuteReader();
            while (reader6.Read())
            {
                LblOrtalamaMaas.Text = reader6[0].ToString();
            }
            _baglanti.Close();

        }
    }
}
