using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        private string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: "+ comboBox1.Text +"-"+ comboBox2.Text + " Saat:" + maskedTextBox1.Text +" Tarih: " + dateTimePicker1.Text+" Yolcu Ad-Soyad: "+textBox1.Text+" TC: "+maskedTextBox2.Text+" Tel: "+maskedTextBox3.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            lblGhost.Text = comboBox1.Text;
            comboBox1.Text =comboBox2.Text;
            comboBox2.Text=lblGhost.Text;
            lblGhost.Text = "";

        }

    }
}
