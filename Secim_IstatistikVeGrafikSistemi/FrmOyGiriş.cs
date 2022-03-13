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
    public partial class FrmOyGiriş : Form
    {
        public FrmOyGiriş()
        {
            InitializeComponent();
        }
        SqlConnection adres = new SqlConnection("Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=SecimİstatistikProje;Integrated Security=True");

        private void BtnOyGirisi_Click(object sender, EventArgs e)
        {
            adres.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)",adres);
            cmd.Parameters.AddWithValue("@p1",TxtilceAD.Text);
            cmd.Parameters.AddWithValue("@p2",TxtA.Text);
            cmd.Parameters.AddWithValue("@p3",TxtB.Text);
            cmd.Parameters.AddWithValue("@p4",TxtC.Text);
            cmd.Parameters.AddWithValue("@p5",TxtD.Text);
            cmd.Parameters.AddWithValue("@p6",TxtE.Text);
            cmd.ExecuteNonQuery();
            adres.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
            
        }
    }
}
