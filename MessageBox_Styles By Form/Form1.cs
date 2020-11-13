using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_Styles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mb_simple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World");
        }

        private void btn_mb_title_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World", "Welcome");
        }

        private void btn_mb_title_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World", "Welcome", MessageBoxButtons.OKCancel);
        }

        private void btn_title_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
