using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_View_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddNode_Click(object sender, EventArgs e)
        {
            if (tb_node.Text != string.Empty) {
                TreeNode n = new TreeNode(tb_node.Text);
                treeView1.Nodes.Add(n);
                
            }
        }

        private void btn_AddSubNode_Click(object sender, EventArgs e)
        {
            if (tb_node.Text != string.Empty && treeView1.SelectedNode != null)
            {
                TreeNode n = new TreeNode(tb_node.Text);
                treeView1.SelectedNode.Nodes.Add(n);

            }
        }
    }
}
