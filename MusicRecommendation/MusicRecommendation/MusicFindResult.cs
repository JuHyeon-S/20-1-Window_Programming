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
using System.Drawing.Printing;

namespace MusicRecommendation
{
    public partial class MusicFindResult : Form
    {
        public MusicFindResult()
        {
            InitializeComponent();
        }

        private void filesave(string filename)
        {
            using (StreamWriter sr = new StreamWriter(filename))
            {
                string str;
                foreach(ListViewItem a in listView1.Items)
                {
                    str = a.SubItems[0].Text + ";";
                    str += a.SubItems[1].Text + ";";
                    str += a.SubItems[2].Text;
                    sr.WriteLine(str);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\서주현\source\repos\C#\20-1-Window_Programming";
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                filesave(saveFileDialog1.FileName);
                MessageBox.Show(saveFileDialog1.FileName + " 저장완료");
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = string.Empty;
            foreach (ListViewItem a in listView1.Items)
            {
                str = a.SubItems[0].Text + ";";
                str += a.SubItems[1].Text + ";";
                str += a.SubItems[2].Text + "\n";
            }
            Font f = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString(str, f, Brushes.Black, 10, 10);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show(printDocument1.DocumentName + "인쇄완료", "end");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.PrinterSettings = new PrinterSettings();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
