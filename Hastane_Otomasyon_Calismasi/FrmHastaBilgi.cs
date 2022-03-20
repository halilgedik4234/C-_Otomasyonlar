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
    public partial class FrmHastaBilgisi : Form
    {
        public FrmHastaBilgisi()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaBilgisi_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            // Ad-Soyad Çekme
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", tc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0] + " " + reader[1];
            }
            bgl.baglanti().Close();


            // Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            // Branşları Çekme
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader reader2= cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader reader3= cmd3.ExecuteReader();
            while (reader3.Read())
            {
                cmbDoktor.Items.Add(reader3[0]+ " " +reader3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+ cmbBrans.Text+ "'" + " and RandevuDoktor='"+cmbDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgilerimiDüzenle fr = new FrmBilgilerimiDüzenle();
            fr.TCno = lblTC.Text;
            
            fr.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Randevular set RandevuDurum=1, HastaTC=@p1,HastaSikayet=@p2 where RandevuId=@p3",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            cmd.Parameters.AddWithValue("@p2", rtbSikayet.Text);
            cmd.Parameters.AddWithValue("@p3", txtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
     
        }

        private void linkLabelGeriGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
