using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Dersİslemleri : Form
    {
        public Dersİslemleri()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();


        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgretmenDetayPaneli frm = new OgretmenDetayPaneli();
            frm.Show();
            this.Hide();
        }

        private void Dersİslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(TxtDersAdı.Text);
            MessageBox.Show(" Ders Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ds.DersListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(TxtDersId.Text));
            MessageBox.Show(" Ders Silinmiştir ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(TxtDersAdı.Text,byte.Parse(TxtDersId.Text));
            MessageBox.Show(" Ders Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDersAdı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
