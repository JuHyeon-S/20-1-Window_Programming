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
        DateTime starTime;

        public Form1()
        {
            InitializeComponent();
            starTime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(starTime.ToString() + "\n" + e.GetType());
        }

        
    }
}
