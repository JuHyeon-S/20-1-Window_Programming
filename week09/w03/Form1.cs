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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) 
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("입력 데이터가 없습니다.", "입력 오류");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] item = { "Button", "CheckBox", "RadioButton", "Lable" };
            listBox1.Items.AddRange(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            foreach (var obj in checkedListBox1.CheckedItems)
            {
                str += $"{obj.ToString()} \r\n";
                listBox1.Items.Add(obj.ToString());
            }
            MessageBox.Show($"{str}리스트 상자에 추가", "항목 추가");
        }
    }
}
