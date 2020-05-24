using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void change(Button b)
        {
            label1.Text = "버튼 스타일 : " + b.FlatStyle.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //Button b = sender as Button;
            change(b);
        }
    }
}
