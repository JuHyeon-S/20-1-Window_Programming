using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Text = "FixedSingle";
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Text = "None";
            FormBorderStyle = FormBorderStyle.None;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Text = "FixedDialog";
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Text = "FixedToolWindow";
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
