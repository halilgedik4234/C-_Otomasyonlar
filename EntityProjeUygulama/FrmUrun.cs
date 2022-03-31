using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();


        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrunAdı.Text;
            t.MARKA = TxtMarka.Text;
            t.STOK = short.Parse(TxtStok.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.DURUM = true; // urun başlangıçta bitmeyeceği için true gönderdik
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedilmiştir");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silinmiştir", "Uyarı");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = TxtUrunAdı.Text;
            urun.MARKA = TxtMarka.Text;
            urun.STOK = short.Parse(TxtStok.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellenmiştir", "Uyarı");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TxtDurum.Text = "";
            TxtFiyat.Text = "";
            TxtID.Text = "";
            TxtMarka.Text = "";
            TxtStok.Text = "";
            TxtUrunAdı.Text = "";
        }
    }
}
