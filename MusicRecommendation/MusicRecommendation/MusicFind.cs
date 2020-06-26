using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRecommendation
{
    public partial class MusicFind : Form
    {
        public MusicFind()
        {
            InitializeComponent();
        }

        private int check()
        {
            if (radioButton1.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else 
            {
                return 3;
            }
        }

        private MusicFindResult find(int i)
        {
            ListView ml = ((MusicList)Owner).listView1;
            MusicFindResult mfr = new MusicFindResult();
            ListViewItem target = new ListViewItem();
            ListViewItem find;
            MessageBox.Show(textBox1.Text);

            if (i == 1)
            {
                foreach (ListViewItem t in ml.Items)
                {
                    if (t.SubItems[0].Text == textBox1.Text)
                    {
                        target = new ListViewItem(t.SubItems[0].Text);
                        target.SubItems.Add(t.SubItems[1].Text);
                        target.SubItems.Add(t.SubItems[2].Text);
                    }
                }
                foreach (ListViewItem lv in ((MusicList)Owner).listView1.Items)
                {
                    if (lv.SubItems[1].Text == target.SubItems[1].Text)
                    {
                        find = new ListViewItem(lv.SubItems[0].Text);
                        find.SubItems.Add(lv.SubItems[1].Text);
                        find.SubItems.Add(lv.SubItems[2].Text);
                        mfr.listView1.Items.Add(find);
                    }
                    else if (lv.SubItems[2].Text == target.SubItems[2].Text)
                    {
                        find = new ListViewItem(lv.SubItems[0].Text);
                        find.SubItems.Add(lv.SubItems[1].Text);
                        find.SubItems.Add(lv.SubItems[2].Text);
                        mfr.listView1.Items.Add(find);
                    }
                }
            }
            else if (i == 2)
            {
                foreach (ListViewItem a in ml.Items)
                {
                    if (a.SubItems[1].Text == textBox1.Text)
                    {
                        find = new ListViewItem(a.SubItems[0].Text);
                        find.SubItems.Add(a.SubItems[1].Text);
                        find.SubItems.Add(a.SubItems[2].Text);
                        mfr.listView1.Items.Add(find);
                    }
                }
            }
            else if(i == 3)
            {
                foreach (ListViewItem a in ml.Items)
                {
                    if (a.SubItems[2].Text == textBox1.Text)
                    {
                        find = new ListViewItem(a.SubItems[0].Text);
                        find.SubItems.Add(a.SubItems[1].Text);
                        find.SubItems.Add(a.SubItems[2].Text);
                        mfr.listView1.Items.Add(find);
                        MessageBox.Show("5");
                    }
                }
            }
            return mfr;
        }

        public int c;
        private void button1_Click(object sender, EventArgs e)
        {
            c = check();
            MessageBox.Show(c.ToString());

            MusicFindResult mfr = find(c);
            mfr.Show();
        }
    }
}
