using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] years = { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" };
            comboBox1.Items.AddRange(years);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            str += $"이름 : {textBox1.Text}, 입학년도 : {comboBox1.SelectedItem},";
            
            foreach (Control cr in groupBox1.Controls)
            {
                RadioButton r = cr as RadioButton;
                if (r != null && r.Checked == true)
                    str += $" 평점: {r.Text}, ";
            }
            str += "이수과목: ";
            foreach (CheckBox cb in groupBox2.Controls)
            {
                if (cb.Checked == true)
                    str += cb.Text + " ";
            }

            listBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
