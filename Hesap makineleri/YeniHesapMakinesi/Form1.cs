using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniHesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private double _ilksayi;
        private bool d;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text="";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "1";
        }

        private void rakamBtn2_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "2";
        }

        private void rakamBtn3_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "3";
        }

        private void rakamBtn4_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "4";
        }

        private void rakamBtn5_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "5";
        }

        private void rakamBtn6_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "6";
        }

        private void rakamBtn7_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "7";
        }

        private void rakamBtn8_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "8";
        }

        private void rakamBtn9_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "9";
        }

        private void rakamBtn0_Click(object sender, EventArgs e)
        {
            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += "0";
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            ekranTextBox.Text = "0";
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ilksayi = Convert.ToDouble(ekranTextBox.Text);
            ekranTextBox.Text = "+"; 
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ilksayi = Convert.ToDouble(ekranTextBox.Text);
            ekranTextBox.Text = "-";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ilksayi = Convert.ToDouble(ekranTextBox.Text);
            ekranTextBox.Text = "x";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ilksayi = Convert.ToDouble(ekranTextBox.Text);
            ekranTextBox.Text = "/";
        }
        private void btnNokta_Click(object sender, EventArgs e)
        {

            if (ekranTextBox.Text == "0") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "+") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "-") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "/") ekranTextBox.Text = "";
            else if (ekranTextBox.Text == "x") ekranTextBox.Text = "";
            ekranTextBox.Text += ".";
        }
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            double sonuc ;
            double ikincisayi = Convert.ToDouble(ekranTextBox.Text);
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                  
                    ekranTextBox.Text = Convert.ToString(sonuc);
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    ekranTextBox.Text = Convert.ToString(sonuc);
                    break;
                case 'x':
                    sonuc = _ilksayi * ikincisayi;
                    ekranTextBox.Text = Convert.ToString(sonuc);
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                 ekranTextBox.Text = Convert.ToString(sonuc);
                    break;
                    default:
                    sonuc = 0;
                    break;
            }
        }

        
    }
}
