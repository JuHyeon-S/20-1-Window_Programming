using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02_1
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            this.Tag = new SampleTag { _A = 30, _B = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = !button2.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor[] cursor = { Cursors.Arrow, Cursors.Cross, Cursors.Hand, Cursors.AppStarting, Cursors.No, Cursors.IBeam, Cursors.Help };
            if (index == cursor.Length)
                index = 0;
            button2.Cursor = cursor[index++];
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Tag.ToString();
        }
    }

    class SampleTag 
    {
        public int _A { get; set; }
        public int _B { get; set; }

        public int hap()
        {
            return _A + _B;
        }

        public override string ToString()
        {
            return $"Tag_A : {_A}, Tag_B : {_B}";
        }
    }
}
