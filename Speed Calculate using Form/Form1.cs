using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Calculate_using_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {

                double dist = double.Parse(txtDistance.Text);
                double time = double.Parse(txtTime.Text);
                double avg_speed = dist / time;
                txtSpeed.Text = avg_speed.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeed.Text = string.Empty;
            txtTime.Text = string.Empty;
            txtDistance.Text = string.Empty;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
