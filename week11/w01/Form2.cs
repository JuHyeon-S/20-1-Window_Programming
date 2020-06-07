﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = sender as TextBox;
            t.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar < '9') || e.KeyChar == '-')
                textBox2.Text += e.KeyChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str = textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text;
            ((Form1)this.Owner).listBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
