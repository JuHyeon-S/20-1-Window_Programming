using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03
{
    public partial class Form1 : Form
    {
        DateTime today;
        DateTime future;
        DateTime past;
        int cnt = 1;
        int check = 1;
        public Form1()
        {
            InitializeComponent();
            today = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(check != 2)
            {
                cnt = 1;
            }
            past = today.AddDays(cnt * (-10));
            MessageBox.Show("현재 날짜 : " + today.ToString() + "\n" + (10 * cnt) + "일 전 날짜 : " + past.ToString());
            check = 2;
            cnt++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (check != 3)
            {
                cnt = 1;
            }
            future = today.AddDays(cnt * (10));
            MessageBox.Show("현재 날짜 : " + today.ToString() + "\n" + (10 * cnt) + "일 후 날짜 : " + future.ToString());
            check = 3;
            cnt++;
        }
    }
}
