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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1" , mskTc.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.Tctasima= mskTc.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
            
        }

        private void linkLabelGeriGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
