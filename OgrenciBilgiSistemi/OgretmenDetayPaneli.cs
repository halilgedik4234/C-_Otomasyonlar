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
    public partial class OgretmenDetayPaneli : Form
    {
        public OgretmenDetayPaneli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KulupİslemleriPaneli frm = new KulupİslemleriPaneli();
            frm.Show();
            this.Hide();

        }

        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Girisler frm = new Girisler();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dersİslemleri drs = new Dersİslemleri();
            drs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm = new FrmOgrenci();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SınavNotlarıPaneli frm = new SınavNotlarıPaneli();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogretmenler frm = new Ogretmenler();
            frm.Show();
            this.Hide();
        }
    }
}
