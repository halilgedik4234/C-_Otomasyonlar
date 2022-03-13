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
    public partial class SınavNotlarıPaneli : Form
    {
        public SınavNotlarıPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();


        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(MskOgrenciTC.Text);  // Tc girildiğinde o öğrencinin notlarını çekme

        }

        int notid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MskOgrenciTC.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            CmbDers.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void SınavNotlarıPaneli_Load(object sender, EventArgs e)
        {   
            //ComboBOX'a Dersleri çekme
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Dersler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.DisplayMember = "DersAd";
            CmbDers.ValueMember = "DersId";
            CmbDers.DataSource = dt;
            bgl.baglanti().Close();


        }

        int sınav1, sınav2, sınav3, proje;

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtDurum.Text = "";
            TxtProje.Text = "";
            TxtSınav1.Text = "";
            TxtSınav2.Text = "";
            TxtSınav3.Text = "";
            TXtOrtalama.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OgretmenDetayPaneli frm = new OgretmenDetayPaneli();
            frm.Show();
            this.Hide();
        }

        double ortalama;

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //string durum;
            sınav1 = Convert.ToInt32(TxtSınav1.Text);
            sınav2 = Convert.ToInt32(TxtSınav2.Text);
            sınav3 = Convert.ToInt32(TxtSınav3.Text);
            proje  = Convert.ToInt16(TxtProje.Text);
            ortalama = (sınav1 + sınav2 + sınav3+ proje) / 4;
            TXtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Notlar set Ortalama=@p1,Durum=@p2,Sınav1=@p5,sınav2=@p6,sınav3=@p7,proje=@p8 where OgrenciTC=@p3 and DersId=@p4", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TXtOrtalama.Text);
            cmd.Parameters.AddWithValue("@p2",TxtDurum.Text);
            cmd.Parameters.AddWithValue("@p3",MskOgrenciTC.Text);
            cmd.Parameters.AddWithValue("@p4", CmbDers.Text);
            cmd.Parameters.AddWithValue("@p5", TxtSınav1.Text);
            cmd.Parameters.AddWithValue("@p6", TxtSınav2.Text);
            cmd.Parameters.AddWithValue("@p7", TxtSınav3.Text);
            cmd.Parameters.AddWithValue("@p8", TxtProje.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notlar Güncellenmiştir (Ortalama ve Durum Değerleri de Sistem Tarafından Eklenmiştir.)", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
            dataGridView1.DataSource = ds.NotListesi(MskOgrenciTC.Text); // Notları güncelledikten sonra Güncel verileri görmek için dataGrid de 

        }
    }
}
