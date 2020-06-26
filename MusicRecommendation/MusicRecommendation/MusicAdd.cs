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
    public partial class MusicAdd : Form
    {
        public MusicAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem i = new ListViewItem(textBox1.Text);
            i.SubItems.Add(textBox2.Text);
            i.SubItems.Add(textBox3.Text);

            ((MusicList)Owner).listView1.Items.Add(i);

            MessageBox.Show("등록 완료!");
        }
    }
}
