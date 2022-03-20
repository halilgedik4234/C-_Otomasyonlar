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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtBransAd.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branş Eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Branslar where BransId=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtBransId.Text);
            cmd.ExecuteNonQuery ();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where BransId=@p2",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtBransAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtBransId.Text);
            cmd.ExecuteNonQuery () ;
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
