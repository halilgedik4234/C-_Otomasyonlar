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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgretmenDetayPaneli dty = new OgretmenDetayPaneli();
            dty.Show();
            this.Hide();
        }


        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Kulupler",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrenciKulubu.DisplayMember = "KulupAd";
            cmbOgrenciKulubu.ValueMember = "KulupId";
            cmbOgrenciKulubu.DataSource = dt;
            bgl.baglanti().Close();

        }
        string c = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            ds.OgrenciEkle(TxtOgrenciAdı.Text,TxtOgrenciSoyadı.Text,byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()),c,mskTC.Text);
            MessageBox.Show("Öğrenci ekleme yapıldı");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            TxtOgrenciId.Text = "";
            TxtOgrenciAdı.Text = "";
            TxtOgrenciSoyadı.Text = "";
            cmbOgrenciKulubu.Text = "";
            mskTC.Text = "";
            TxtAra.Text = "";
        }

        private void cmbOgrenciKulubü_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtOgrenciId.Text = cmbOgrenciKulubu.SelectedValue.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtOgrenciId.Text));
            MessageBox.Show("Silindi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtOgrenciAdı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtOgrenciSoyadı.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbOgrenciKulubu.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.Equals("Kız"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.Equals("Erkek"))
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton2.Checked= false;
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtOgrenciAdı.Text, TxtOgrenciSoyadı.Text,byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()),c, mskTC.Text.ToString(), int.Parse(TxtOgrenciId.Text));
            MessageBox.Show("Güncellendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                c = "ERKEK";
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Ogrenciler where OgrenciAd=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TxtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
