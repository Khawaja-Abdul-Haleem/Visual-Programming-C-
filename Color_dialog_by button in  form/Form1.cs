using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (btn_red.Checked) {
                this.BackColor = Color.Red;
            }
            else if (btn_green.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (btn_blue.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (btn_gray.Checked)
            {
                this.BackColor = Color.Gray;
            }

            if (btn_white.Checked)
            {
                this.ForeColor = Color.White;
            }
            else if (btn_black.Checked)
            {
                this.ForeColor = Color.Black;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
