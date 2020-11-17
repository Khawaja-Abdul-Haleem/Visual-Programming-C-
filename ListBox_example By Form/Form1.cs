using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Box_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string subject = textBox1.Text;
            lb_subject.Items.Add(subject);
            textBox1.Clear();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            string rem_sub = textBox1.Text;
            if (lb_subject.Items.Contains(rem_sub))
            {
                lb_subject.Items.Remove(rem_sub);
            }
            else
                MessageBox.Show("Not Available in List");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int i = lb_subject.SelectedIndex;
            if (i == -1)
            {
                MessageBox.Show("Slect Subject to Move");
            }
            else
                lb_subject.Items.RemoveAt(i);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_subject.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
