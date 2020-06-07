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

        private void clear()
        {            
            domainUpDown1.Text = domainUpDown1.Items[0].ToString();
            numericUpDown1.Value = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Focus())
            {
                int a = domainUpDown1.SelectedIndex;
                if (a >= 0)
                    textBox1.Text = domainUpDown1.Items[a].ToString();
            }                
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = numericUpDown1.Value.ToString();
        }

        private ListViewItem listAdd()
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = (int.Parse(b) * int.Parse(c)).ToString();

            return new ListViewItem(new string[] { a, b, c, d });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(listAdd());
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
                listView1.Items.Remove(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
