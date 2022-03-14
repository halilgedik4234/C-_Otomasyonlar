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

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text=yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa") 
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor= Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break ;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "çalışkan")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            LblDogruSayısı.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            LabelYanlısSayısı.Text = yanlis.ToString();

                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
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

                case 6:
                    richTextBox1.Text = " Padişahların emirlerinin yazılı haline ne denir ?";
                    button6.BackColor = Color.Yellow;
                    break;

                case 7:
                    richTextBox1.Text = " Dünyamızın Isı Kaynağı ?";
                    button7.BackColor = Color.Yellow;
                    break;

                case 8:
                    richTextBox1.Text = " Öğrenciler arasında 'İnek' tabiri ne demektir ?";
                    button8.BackColor = Color.Yellow;
                    break;

                case 9:
                    richTextBox1.Text = " Gülüyle ünlü ilimiz ?";
                    button9.BackColor = Color.Yellow;
                    break;

                case 10:
                    richTextBox1.Text = " Mersinin Diğer İsmi ?";
                    button10.BackColor = Color.Yellow;
                    break;

                case 11:
                    richTextBox1.Text = " Havada en çok bulunuan bileşen ?";
                    button11.BackColor = Color.Yellow;
                    break;

                case 12:
                    richTextBox1.Text = " Konyanın neyi ile ünlüdür ?";
                    button12.BackColor = Color.Yellow;
                    break;

                case 13:
                    richTextBox1.Text = " Her yıl Bahar aylarında düzenlenen meşhur çicek festivali  ?";
                    button13.BackColor = Color.Yellow;
                    break;

                case 14:
                    richTextBox1.Text = " Konyanın neyi ile ünlüdür ?";
                    button14.BackColor = Color.Yellow;
                    break;

                case 15:
                    richTextBox1.Text = " 3. ayın ingilizcesi nedir ?";
                    button15.BackColor = Color.Yellow;
                    break;

                case 16:
                    richTextBox1.Text = " Üflemeli Müzik Aleti ?";
                    button16.BackColor = Color.Yellow;
                    break;

                case 17:
                    richTextBox1.Text = " Çocukların çok sevmediği pirinç,havuç gibi şeylerden yapılan yemek ?";
                    button17.BackColor = Color.Yellow;
                    break;

                case 18:
                    richTextBox1.Text = " 11 ayın sultanı diye hitap edilen ay nedir  ?";
                    button18.BackColor = Color.Yellow;
                    break;

                case 19:
                    richTextBox1.Text = " İngilizce 'What is he/she like ? ' ne anlama gelmektedir ";
                    button19.BackColor = Color.Yellow;
                    break;

                case 20:
                    richTextBox1.Text = " Türkiyenin cumhurbaşkanı ?";
                    button20.BackColor = Color.Yellow;
                    break;

                case 21:
                    richTextBox1.Text = " Ümit kelimesinin eş anlamlısı nedir ?";
                    button21.BackColor = Color.Yellow;
                    break;

                case 22:
                    richTextBox1.Text = " Kahvaltısı ile ünlü ilimiz ?";
                    button22.BackColor = Color.Yellow;
                    break;

                case 23:
                    richTextBox1.Text = " Şimşek kelimesinin eş anlamlısı ?";
                    button23.BackColor = Color.Yellow;
                    break;

                case 24:
                    richTextBox1.Text = " Ege bölgesinin en çok ağacı bulunan yağıda yapılan bir kahvaltı besini ?";
                    button24.BackColor = Color.Yellow;
                    break;



                default:
                    break;
            }

        }

    }
}
