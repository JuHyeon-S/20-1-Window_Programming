using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorChange(TrackBar t)
        {
            int i = t.TabIndex;
            switch (i)
            {
                case 1:
                    label2.Text = trackBar1.Value.ToString();
                    break;
                case 2:
                    label3.Text = trackBar2.Value.ToString();
                    break;
                case 3:
                    label4.Text = trackBar3.Value.ToString();
                    break;

            }
            label1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            colorChange(sender as TrackBar);
        }
    }
}
