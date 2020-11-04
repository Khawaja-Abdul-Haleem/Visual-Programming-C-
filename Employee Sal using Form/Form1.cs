using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Using_Windows_Form
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNetSal.Text = string.Empty;
            txtAnnSal.Text = string.Empty;
            txtBasicSalary.Text = string.Empty;
            txtDeduction.Text = string.Empty;
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtTAX.Text = string.Empty;
            
        }

        private void btnCAL_Click(object sender, EventArgs e)
        {
            try
            {
                double sal = double.Parse(txtBasicSalary.Text);
                double tax = sal * 0.06;
                double deduct = double.Parse(txtDeduction.Text);
                double net_sal = sal - tax - deduct;
                double ann_sal = net_sal * 12;

                txtTAX.Text = tax.ToString();
                txtAnnSal.Text = ann_sal.ToString();
                txtNetSal.Text = net_sal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            } // catch end bracket
        }
    }
}
