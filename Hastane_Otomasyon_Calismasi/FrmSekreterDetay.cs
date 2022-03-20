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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string Tctasima;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = Tctasima;

            // Ad Soyadı Çekme
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0].ToString();
            }
            bgl.baglanti().Close();


            //Branşları dataGridView'a aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransId,BransAd from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select  (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from  Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Branşları ComboBox'a Aktarma
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();

          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktorları ComboBox'a Aktarma
            cmbDoktor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select (DoktorAd + ' ' + DoktorSoyad) from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                cmbDoktor.Items.Add(reader3[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand ("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturulmuştur.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();  
            fr.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm = new FrmBransPaneli();
            frm.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void linkLabelGeriGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
