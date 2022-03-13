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
namespace Secim_IstatistikVeGrafikSistemi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection adres = new SqlConnection("Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=SecimİstatistikProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilçe adlarını ComboBox'a çekme
            adres.Open();
            SqlCommand cmd = new SqlCommand("select ILCEAD from TBLILCE",adres);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            adres.Close();


            // grafiğe toplam sonuçları getirme
            adres.Open();
            SqlCommand cmd2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE", adres);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[4]);
            }
        }
    }
}
