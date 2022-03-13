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
    public partial class Ogretmenler : Form
    {
        public Ogretmenler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            OgretmenleriListele();

        }

        private void OgretmenleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Ogretmenler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgretmenTC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            OgretmenAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            OgretmenBrans.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OgretmenDetayPaneli frm = new OgretmenDetayPaneli();
            frm.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update from Tbl_Ogretmenler set OgretmenBrans=@p1,OgretmenAdSoyad=@p2 where OgretmenTC=@p3", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", OgretmenBrans.Text);
            cmd.Parameters.AddWithValue("@p2", OgretmenAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", OgretmenTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen Bilgileri Güncellenmiştir");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            OgretmenAdSoyad.Text = "";
            OgretmenBrans.Text = "";
            OgretmenTC.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Ogretmenler (OgretmenTC,OgretmenAdSoyad,OgretmenBrans) values (@p1,@p2,@p3)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p3", OgretmenBrans.Text);
            cmd.Parameters.AddWithValue("@p2", OgretmenAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p1", OgretmenTC.Text);
            cmd.Parameters.AddWithValue("@p4", OgretmenTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen Sisteme Kaydolmuştur");
            OgretmenleriListele();

        }
    }
}
