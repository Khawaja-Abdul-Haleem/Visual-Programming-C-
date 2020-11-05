using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cbitems.SelectedItem != null)
            {
                int bill = 0;
                if (rbcash.Checked)
                {
                    if (cbitems.SelectedIndex == 0)
                    {
                        bill += 950;
                    }
                    else if (cbitems.SelectedIndex == 1)
                    {
                        bill += 1800;
                    }
                    else if (cbitems.SelectedIndex == 2)
                    {
                        bill += 550;
                    }
                    else if (cbitems.SelectedIndex == 3)
                    {
                        bill += 900;
                    }
                    else if (cbitems.SelectedIndex == 4)
                    {
                        bill += 1200;
                    }
                    else if (cbitems.SelectedIndex == 5)
                    {
                        bill += 1200;
                    }

                    if (chbraita.Checked)
                        bill += 70;
                    if (chbsalad.Checked)
                        bill += 70;

                    txtBill.Text = bill.ToString();
                    MessageBox.Show("Payed By Cash");

                } // if end bracket

                else if (rbcredit.Checked)
                {
                    if (cbitems.SelectedIndex == 0)
                    {
                        bill += 950;
                    }
                    else if (cbitems.SelectedIndex == 1)
                    {
                        bill += 1800;
                    }
                    else if (cbitems.SelectedIndex == 2)
                    {
                        bill += 550;
                    }
                    else if (cbitems.SelectedIndex == 3)
                    {
                        bill += 900;
                    }
                    else if (cbitems.SelectedIndex == 4)
                    {
                        bill += 1200;
                    }
                    else if (cbitems.SelectedIndex == 5)
                    {
                        bill += 1200;
                    }

                    if (chbraita.Checked)
                        bill += 70;
                    if (chbsalad.Checked)
                        bill += 70;

                    txtBill.Text = bill.ToString();
                    MessageBox.Show("Payed By Credit Card");
                } // if end bracket

                else
                    MessageBox.Show("Check Payment Method");
            } // if ending bracket
            else
                MessageBox.Show("Select Item First");
        }
    }
}
