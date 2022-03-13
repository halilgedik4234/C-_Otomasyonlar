using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_ProjeAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kitaplik3.mdb");

        void listele()
        {
            baglanti.Open();
           DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        String durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("inser into Kitaplar (KitapAdi,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            cmd.Parameters.AddWithValue("@p1" ,TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtYazar.Text);
            cmd.Parameters.AddWithValue("@p3", CmbTur.Text);
            cmd.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
            listele();
        }

        private void RbikinciEl_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void RbYeni_CheckedChanged(object sender, EventArgs e)
        {
            durum="1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSayfa.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()== "True")
            {
                RbYeni.Checked = true;
            }
            else
            {
                RbikinciEl.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from Kitaplar where Kitapid=@p1",baglanti);
            cmd.Parameters.AddWithValue("@p1",Txtid.Text );
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silinmiştir","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Update from Kitaplar set KitapAdi=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where Kitapid=@p6",baglanti);
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtYazar.Text);
            cmd.Parameters.AddWithValue("@p3", CmbTur.Text);
            cmd.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            if (RbYeni.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", durum);
            }
            if (RbikinciEl.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", durum);
            }
            cmd.Parameters.AddWithValue("@p6", Txtid.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kayıtı Güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }


        // Arama Yapma
        private void BtnAra_Click(object sender, EventArgs e)
        {
           
            OleDbCommand cmd = new OleDbCommand("Select * from Kitaplar where KitapAdi=@p1",baglanti);
            cmd.Parameters.AddWithValue("@p1",TxtKitapAra.Text);
            DataTable dt = new DataTable();                     // Grid'e yazdıracağımız için kullandık DataTable
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           


        }
    }
}
