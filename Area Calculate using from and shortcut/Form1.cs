using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_area_by_shortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "C")
                btnCal.PerformClick();
            else if (e.Alt && e.KeyCode.ToString() == "R")
                btnClear.PerformClick();
            else if (e.Alt && e.KeyCode.ToString() == "X")
                btnExit.PerformClick();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {

                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double area = length * width;
                txtArea.Text = area.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtArea.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
