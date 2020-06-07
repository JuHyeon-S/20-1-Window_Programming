using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text));
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
                treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                listBox1.Items.Add(treeView1.SelectedNode.Parent?.Text);
                listBox1.Items.Add(treeView1.SelectedNode.Text);
                if(treeView1.SelectedNode.Nodes != null)
                {
                    foreach(TreeNode node in treeView1.SelectedNode.Nodes)
                        listBox1.Items.Add(node.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
