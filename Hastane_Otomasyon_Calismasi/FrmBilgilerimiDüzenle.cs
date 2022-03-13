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

namespace Hastane_Otomasyon_Calısması
{
    public partial class FrmBilgilerimiDüzenle : Form
    {
        public FrmBilgilerimiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBilgilerimiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtAd.Text = reader[1].ToString();
                txtSoyad.Text = reader[2].ToString();
                //TC yi çektik zaten gerek yok
                mskTelefon.Text = reader[4].ToString();
                txtSifre.Text = reader[5].ToString();
                cmbCinsiyet.Text = reader[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand(" Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            cmd2.Parameters.AddWithValue("@p4", txtSifre.Text);
            cmd2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            cmd2.Parameters.AddWithValue("@p6", mskTC.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        
    }
}
