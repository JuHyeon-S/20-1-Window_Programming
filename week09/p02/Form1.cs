using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            string place = comboBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string pw = textBox2.Text;

            string lang = "언어:";
            foreach (CheckBox cb in groupBox1.Controls)
            {
                if (cb.Checked)
                    lang += cb.Text + " ";
            }
            item = $"이름: {name} pw:{pw} 거주지: {place} {lang}";
            listBox1.Items.Add(item);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString().Substring(3, 2);
            MessageBox.Show(name + "..님을 삭제 합니다.", "삭제확인");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int idx = listBox1.FindString($"이름: {textBox1.Text}");
            if(idx != -1)
            {
                listBox1.SetSelected(idx, true);
            }
            else
            {
                MessageBox.Show(textBox1.Text + "님은 미등록", "등록확인");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            foreach(CheckBox cb in groupBox1.Controls)
            {
                if (cb.Checked)
                    cb.Checked = false;
            }
            listBox1.ClearSelected();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] place = { "서울", "춘천", "대전", "부산", "대구", "제주", "광주", "강릉", "원주" };
            comboBox1.Items.AddRange(place);
        }
    }
}