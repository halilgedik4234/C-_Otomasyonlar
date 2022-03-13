using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TURİZM_BİLET_SEÇİM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdButtonErkek.Checked) { button1.BackColor = Color.LightBlue; }
            else { button1.BackColor = Color.Pink; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            if (rdButtonErkek.Checked)
            {
              
            }
            else 
            {
                
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }
    }
}
