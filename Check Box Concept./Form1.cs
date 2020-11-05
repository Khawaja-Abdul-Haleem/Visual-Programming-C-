using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string msg = "Your order includes ";
            if (cbSugar.Checked == true)
                msg = msg + "Sugar ";
            if (cbStrong.Checked == true)
                msg += "Strong ";
            MessageBox.Show(msg);
        }
    }
}
