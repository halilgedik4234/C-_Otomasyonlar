using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilksayı;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text=="0") { ekranLabel.Text = "";}
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) ekranLabel.Text = ""; _ekranTemizlenecekMi = false;
            if (ekranLabel.Text == "0") { ekranLabel.Text = ""; }
            ekranLabel.Text += "0";
        }

        //  -------------  4 İŞLEM BUTONLARI;  ---------------

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpıButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void sonucButton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
         
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayı + ikincisayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case '-':
                    sonuc = _ilksayı - ikincisayi;
                    if (_ilksayı<ikincisayi)
                    {
                        ekranLabel.Text = Convert.ToString(sonuc) ;
                    }
                    else
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case '*':
                    sonuc = _ilksayı * ikincisayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                case '/':
                    sonuc = _ilksayı / ikincisayi;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
                default:
                    sonuc = 0;
                    ekranLabel.Text = Convert.ToString(sonuc);
                    break;
            }
            
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void ekranLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
