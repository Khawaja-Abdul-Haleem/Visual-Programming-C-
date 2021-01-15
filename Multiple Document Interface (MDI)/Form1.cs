using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Document_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            reg.MdiParent = this;
        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.Show();
            fee.MdiParent = this;
        }

        private void teachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teach = new Teachers();
            teach.Show();
            teach.MdiParent = this;
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res.Show();
            res.MdiParent = this;
        }
    }
}
