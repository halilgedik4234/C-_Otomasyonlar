using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayıt
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        SqlConnection _baglanti = new SqlConnection(
            "Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        
         void baglantiKontrolMethod()
        {
            if (_baglanti.State==ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        void Temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked= false;
            radioButton2.Checked= false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet.Tbl_Personel);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglantiKontrolMethod();
            SqlCommand komut = new SqlCommand(
                "insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@ad,@soyad,@sehir,@maas,@durum,@meslek)", _baglanti);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@sehir", cmbSehir.Text);
            komut.Parameters.AddWithValue("@maas", mskMaas.Text);
            komut.Parameters.AddWithValue("@durum", label8.Text);
            komut.Parameters.AddWithValue("@meslek", txtMeslek.Text);
            komut.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text=dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            
        }

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantiKontrolMethod();
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Personel where PerId=@k1",_baglanti);
            komutSil.Parameters.AddWithValue("@k1", txtId.Text);
            komutSil.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("Kayıt Silindi !");

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantiKontrolMethod();
            SqlCommand updatekmt = new SqlCommand("Update Tbl_Personel Set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 where PerId=@p7", _baglanti);
            updatekmt.Parameters.AddWithValue("@p1", txtAd.Text);
            updatekmt.Parameters.AddWithValue("p2", txtSoyad.Text);
            updatekmt.Parameters.AddWithValue("p3",cmbSehir.Text);
            updatekmt.Parameters.AddWithValue("p4",mskMaas.Text);
            updatekmt.Parameters.AddWithValue("p5", label8.Text);
            updatekmt.Parameters.AddWithValue("p6", txtMeslek.Text);
            updatekmt.Parameters.AddWithValue("p7", txtId.Text);
            updatekmt.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("Personel Güncellendi");

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            istatistikForm  fr1=new istatistikForm();
            fr1.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler grf=new FrmGrafikler();
            grf.Show();
        }
    }
}
