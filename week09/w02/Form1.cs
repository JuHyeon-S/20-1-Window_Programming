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
        private void rChange(RadioButton r)
        {
            if (r.Checked)
            {
                string s = r.Text;
                switch (s)
                {
                    case "왼쪽":
                        label3.TextAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "가운데":
                        label3.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    case "오른쪽":
                        label3.TextAlign = ContentAlignment.MiddleRight;
                        break;
                }
            }
        }
        private void cChange(CheckBox c)
        {
            string s = c.Text;
            if (c.Checked)
            {
                switch(s)
                {
                    case "굵게":
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
                        break;
                    case "밑줄":
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
                        break;
                    case "이탤릭":
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
                        break;
                    case "취소선":
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
                        break;
                }
            }
            else
            {
                switch (s)
                {
                    case "굵게":
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Bold);
                        break;
                    case "밑줄":
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);
                        break;
                    case "이탤릭":
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Italic);
                        break;
                    case "취소선":
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Strikeout);
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.DarkOrange, Color.Blue, Color.Brown, Color.DarkGreen, Color.Cyan, Color.DarkBlue, Color.Purple, Color.BlueViolet };
            Random r = new Random();
            int i = r.Next() % colors.Length;
            label3.BackColor = colors[i];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            rChange(r);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            cChange(c);
        }
    }
}