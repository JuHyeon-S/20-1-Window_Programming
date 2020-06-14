using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int p_x;
        private int p_y;
        private int d_x;
        private int d_y;
        private int p ,d;

        Graphics g;
        Rectangle pacman1, dot;

        private void Form1_Load(object sender, EventArgs e)
        {
            p_x = 30;
            d_x = 245;
            d_y = 118;
            p = 2;
            d = 5;
            g = this.CreateGraphics();
            pacman1 = new Rectangle(50, 50, 150, 150);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            dot = new Rectangle(d_x, d_y, 20, 20);

            g.FillPie(Brushes.Red, dot, 0, 360);
            g.FillPie(Brushes.Yellow, pacman1, p_x, p_y);
            g.DrawPie(Pens.Black, pacman1, p_x, p_y);
                        
            if (p_x < 0 || p_y >= 360)
            {
                timer1.Stop();
            }
            else {
                d_x -= d;
                p_x -= p;
                p_y = 360 - 2 * p_x;
            }
        }
    }
}
