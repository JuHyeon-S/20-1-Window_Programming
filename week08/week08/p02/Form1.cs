using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.BringToFront();
            Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.SendToBack();
            Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button3.Show();
            Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button3.Hide();
            Text = button9.Text;
        }
    }
}
