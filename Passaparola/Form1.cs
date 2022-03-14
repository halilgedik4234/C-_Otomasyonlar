using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlıs = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "CEVAPLA";
            soruno++;
            this.Text = soruno.ToString();
            lblSoruNoSayısı.Text = soruno.ToString();

            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi nedir ?";
                    button1.BackColor = Color.Yellow;
                    break;

                case 2:
                    richTextBox1.Text = "Yeşilliği ile ünlü ilimiz ?";
                    button2.BackColor = Color.Yellow;
                    break;

                case 3:
                    richTextBox1.Text = "Müslümanların Kutsal Günü ?";
                    button3.BackColor = Color.Yellow;
                    break;

                case 4:
                    richTextBox1.Text = "Karpuzu ile ünlü ilimiz ?";
                    button4.BackColor = Color.Yellow;
                    break;

                case 5:
                    richTextBox1.Text = " 'İdrak etmek' kelimesinin Anlamı nedir ?";
                    button5.BackColor = Color.Yellow;
                    break;

                case 7:
                    richTextBox1.Text = " Padişahların emirlerinin yazılı haline ne denir ?";
                    button7.BackColor = Color.Yellow;
                    break;

                case 6:
                    richTextBox1.Text = " Dünyamızın Isı Kaynağı ?";
                    button6.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }

        }

    }
}
