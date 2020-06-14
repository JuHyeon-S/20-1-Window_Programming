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
        PenProperty pen;
        private void Form_creation(string text)
        {
            pen = new PenProperty();
            pen.Text = text;
            pen.Owner = this;
            pen.StartPosition = FormStartPosition.CenterScreen;
            pen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Form_creation(b.Text);
        }
    }
}
