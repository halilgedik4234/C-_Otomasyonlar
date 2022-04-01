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

namespace OgrenciBilgiSistemi
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string numara;      // daha sonra ogrenci Tc ile giriş yaparken Tc yi buraya atıyacağız
        
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select  DersAd,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum from Tbl_Notlar INNER JOIN Tbl_Dersler ON Tbl_Notlar.DersId = Tbl_Dersler.DersId where OgrenciTC = @p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", numara);
           // this.Text = numara.ToString();
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("Select (OgrenciAd +' ' + OgrenciSoyad) from Tbl_Ogrenciler where OgrenciTC=@p1",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1",numara);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                this.Text = reader2[0].ToString();
            }

        }
    }
}
