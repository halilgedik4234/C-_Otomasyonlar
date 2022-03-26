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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection _baglanti = new SqlConnection(
            "Data Source=DESKTOP-IHCS472\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            _baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2",_baglanti);
            komut.Parameters.AddWithValue("@p1", txtKadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
               FrmMainForm frm= new FrmMainForm();
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre, Lütfen Tekrar Girdiniz...","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            _baglanti.Close();

            
        }
    }
}
