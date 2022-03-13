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
    public partial class KulupİslemleriPaneli : Form
    {
        public KulupİslemleriPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public void listele()          // method
        {
            TxtKulupAdı.Text = "";
            TxtKulupId.Text = "";
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kulupler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void KulupİslemleriPaneli_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgretmenDetayPaneli frm = new OgretmenDetayPaneli();
            frm.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" insert into Tbl_Kulupler (KulupAd) values (@p1)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TxtKulupAdı.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Kulüp Eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Blue;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKulupId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKulupAdı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete  From Tbl_Kulupler where KulupId=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TxtKulupId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Kulüp Silme İşlemi Gerçekleşmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Kulupler set KulupAd=@p2 where KulupId=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtKulupId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtKulupAdı.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Kulüp Güncelleme İşlemi Gerçekleşmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        
    }
}
