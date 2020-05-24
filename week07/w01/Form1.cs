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
        DateTime curTime;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {      
            curTime = DateTime.Now;
            MessageBox.Show(curTime.ToString(), "로딩...");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            curTime = DateTime.Now;
            MessageBox.Show(curTime.ToString(), "클로징...");
        }
    }
}
