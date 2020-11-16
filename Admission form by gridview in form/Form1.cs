using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Admission_form
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_name.Text;
                double per = int.Parse(tb_per.Text);
                String gender = "";
                if (rb_female.Checked)
                    gender = rb_female.Text;
                else if (rb_male.Checked)
                    gender = rb_male.Text;
                double contact = int.Parse(tb_contact.Text);
                dataGridView1.Rows.Add(name, per, gender, contact);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
