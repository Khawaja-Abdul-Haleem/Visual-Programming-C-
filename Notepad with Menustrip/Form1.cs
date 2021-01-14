using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_with_menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) {
                rtb.LoadFile(openFileDialog1.FileName);

            }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtb.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtb.ForeColor = colorDialog1.Color;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtb.SaveFile(saveFileDialog1.FileName);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
