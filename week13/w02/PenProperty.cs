﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace w02
{
    public partial class PenProperty : Form
    {
        public PenProperty()
        {
            InitializeComponent();
        }
        private void penCap(Graphics g)
        {
            Array LineCapArray = Enum.GetValues(typeof(LineCap));

            int x = 10; 
            int y = 50;

            for(int i = 0; i < LineCapArray.Length; i++)
            {
                Pen myPen = new Pen(Color.BlueViolet, 5);
                LineCap lc = (LineCap)LineCapArray.GetValue(i);
                myPen.StartCap = lc;
                myPen.EndCap = lc;
                g.DrawLine(myPen, x, y, x + 50, y);
                g.DrawString(lc.ToString(), this.Font, Brushes.Black, x + 55, y);
                y += 40;
                myPen.Dispose();
            }
        }

        private void penStyle(Graphics g)
        {
            Array DashStyleArray = Enum.GetValues(typeof(DashStyle));
            Pen myPen = new Pen(Color.DarkGreen);
            Point startp = new Point(10, 15);
            Point endp = new Point(110, 15);

            for (int i = 0; i < DashStyleArray.Length; i++)
            {
                DashStyle lc = (DashStyle)DashStyleArray.GetValue(i);
                myPen.DashStyle = lc;
                g.DrawLine(myPen, startp, endp);
                g.DrawString(myPen.DashStyle.ToString(), this.Font, Brushes.Black, endp);
                startp.Offset(0, 20);
                endp.Offset(0, 20);
            }
        }

        private void PenProperty_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string pen = this.Text;
            switch (pen)
            {
                case "PenCap":
                    penCap(g);
                    break;
                case "PenStyle":
                    this.Height /= 2;
                    penStyle(g);
                    break;
            }
        }
    }
}
