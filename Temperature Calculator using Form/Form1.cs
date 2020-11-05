using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Calculator
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

        private void bnConv_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(txtTemperature.Text);
            if (rbFaren.Checked)
            {
                if (txtTemperature.Text != string.Empty)
                {
                    double res = (temp * 1.8) + 32;
                   // MessageBox.Show("Temperature: " + res );
                    txtResult.Text = res.ToString();
                }
                else
                    MessageBox.Show("Enter Temperature First");
            } // if ending bracket

            else if (rbCelcius.Checked) {
                if (txtTemperature.Text != string.Empty)
                {
                    double res = (temp - 32) * 1.8;
                    //MessageBox.Show("Temperature: " + res);
                    txtResult.Text = res.ToString();
                }
                else
                    MessageBox.Show("Enter Temperature First");
            }
        }
    }
}
