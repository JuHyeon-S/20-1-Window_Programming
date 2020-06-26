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

namespace MusicRecommendation
{
    public partial class MusicList : Form
    {
        public MusicList()
        {
            InitializeComponent();
        }

        private void MAdd(string fileName)
        {
            using (TextReader r = new StreamReader(fileName))
            {
                string[] str = r.ReadToEnd().Replace("\n", "").Split((char)Keys.Enter);
                foreach(string s in str)
                {
                    if(s != string.Empty)
                    {
                        string[] sa = s.Split(';');

                        ListViewItem i = new ListViewItem(sa[0]);
                        i.SubItems.Add(sa[1]);
                        i.SubItems.Add(sa[2]);

                        listView1.Items.Add(i);
                    }
                }
            }
        }

        private void MusicList_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\서주현\source\repos\C#\20-1-Window_Programming\data.txt";
            MAdd(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicAdd ma = new MusicAdd();
            ma.Owner = this;
            ma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicFind mf = new MusicFind();
            mf.Owner = this;
            mf.Show();


        }
    }
}
