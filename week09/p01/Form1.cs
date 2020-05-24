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
        Calcurator cal;

        public Form1()
        {
            InitializeComponent();
        }
        private bool blankCheck(string text1, string text2)
        {
            if(text1 == "" || text2 == "")
            {
                MessageBox.Show("피연산자를 입력해 주세요");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void process(Button b)
        {
            string op = b.Text;
            if (blankCheck(textBox1.Text.Trim(), textBox2.Text.Trim()))
                textClear();
            else
            {
                double data1 = double.Parse(textBox1.Text);
                double data2 = double.Parse(textBox2.Text);
                switch (op)
                {
                    case "+":
                        textBox3.Text = cal.plus(data1, data2).ToString();
                        break;
                    case "-":
                        textBox3.Text = cal.minus(data1, data2).ToString();
                        break;
                    case "*":
                        textBox3.Text = cal.multiply(data1, data2).ToString();
                        break;
                    case "/":
                        textBox3.Text = cal.divide(data1, data2).ToString("0.00");
                        break;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textClear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cal = new Calcurator();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            process(b);
        }
    }
}
