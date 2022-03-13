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
    public partial class FrmDoktorBilgi : Form
    {
        public FrmDoktorBilgi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void FrmDoktorBilgi_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;

            // Doktor Ad-Soyad
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar Where DoktorTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", labelTc.Text );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0] +" "+ reader[1];
            }
            bgl.baglanti().Close();

            // Doktora ait Randevuları Getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='"+ lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView11.DataSource = dt;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO= labelTc.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void dataGridView11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView11.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView11.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
