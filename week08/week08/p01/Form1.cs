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
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form f = (Form)sender;
            f.Height = 400;
            f.Width = 400;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Form f = (Form)sender;

            if (i < 2)
            {
                i++;
            }
            else
            {
                if (f.Width < 300 || f.Height < 300)
                {
                    MessageBox.Show("최소치 미만입니다. 사이즈를 재조정합니다.");
                    if (f.Width < 300)
                    {
                        f.Width = 300;
                    }
                    if (f.Height < 300)
                        f.Height = 300;
                }
                else if (f.Width > 500 || f.Height > 700)
                {
                    MessageBox.Show("최대치 이상입니다. 사이즈를 재조정합니다.");
                    if (f.Width > 500)
                    {
                        f.Width = 500;
                    }
                    if (f.Height > 700)
                        f.Height = 700;
                }
            }
        }      
    }
}
