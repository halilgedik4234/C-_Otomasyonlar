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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmistatistik frm = new Frmistatistik();
            frm.Show();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
