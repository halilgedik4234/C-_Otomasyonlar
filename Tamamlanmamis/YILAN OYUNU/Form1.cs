using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yilan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        yilan yilanimiz = new yilan();
        PictureBox[] pb_yilanparcalari;

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_yilanparcalari = new PictureBox[0];
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref pb_yilanparcalari, pb_yilanparcalari.Length + 1);
                pb_yilanparcalari[i] = Pb_ekle();
            }

        }
        private PictureBox Pb_ekle()
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(10,10);
            pb.BackColor = Color.White;
            pb.Location = yilanimiz.GetPos(pb_yilanparcalari.Length-1);
            panel1.Controls.Add(pb);
            return pb;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
