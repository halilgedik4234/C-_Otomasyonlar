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
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenGiris frm = new OgretmenGiris();
            frm.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciGiris frm = new OgrenciGiris();
            frm.Show();
            this.Hide();
        }


    }
}
