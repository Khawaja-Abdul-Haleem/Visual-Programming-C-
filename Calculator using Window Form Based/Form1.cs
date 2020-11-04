using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_using_form_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtVal1.Text);
            int b = int.Parse(txtVal2.Text);
            int c = a + b;
            txtResult.Text = c.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtVal1.Text);
            int b = int.Parse(txtVal2.Text);
            int c = a / b;
            txtResult.Text = c.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtVal1.Text);
            int b = int.Parse(txtVal2.Text);
            int c = a - b;
            txtResult.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtVal1.Text = string.Empty;
            txtVal2.Text = string.Empty;
            txtResult.Text = string.Empty;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtVal1.Text);
            int b = int.Parse(txtVal2.Text);
            int c = a * b;
            txtResult.Text = c.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
