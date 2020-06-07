using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace w01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 자료입력NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.AddOwnedForm(form2);
            form2.ShowDialog();
        }

        private void 전체삭제XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.Text = "전체삭제";
        }

        private void 선택삭제PToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            for(int i =listBox1.Items.Count - 1; i > 0; i--)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
        }

        private void 글꼴대화상자TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void 색상대화상자CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void fileopen(string filename)
        {
            string text = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    text = sr.ReadLine();
                    listBox1.Items.Add(text);
                }
            } 
        }

        private void 파일불러오기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\서주현\Desktop\20-1\윈도우 프로그래밍\w11";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
                fileopen(openFileDialog1.FileName);
        }

        private void filesave(string filename)
        {
            string str = "";
            using (StreamWriter sr = new StreamWriter(filename))
            {
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    str = listBox1.Items[i] + "";
                    sr.WriteLine(str);
                }
            }
        }
        private void 파일저장하기SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\서주현\Desktop\20-1\윈도우 프로그래밍\w11";
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
                filesave(saveFileDialog1.FileName);
        }

        private void formclose()
        {
            MessageBox.Show("MenuStripApp폼 종료", "폼 종료");
            Dispose();
        }
        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formclose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                formclose();
        }
    }
}
