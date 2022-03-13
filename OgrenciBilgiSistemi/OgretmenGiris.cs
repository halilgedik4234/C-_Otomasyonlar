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
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Girisler frm = new Girisler();
            frm.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Ogretmenler where OgretmenTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                OgretmenDetayPaneli frm = new OgretmenDetayPaneli();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış TC Girdiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        }
    }
}
