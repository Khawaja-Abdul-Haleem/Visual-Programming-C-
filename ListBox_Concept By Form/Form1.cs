using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Box_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_single_fwd_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i == -1) {
                MessageBox.Show("Slect Subject to Move");
            }
            else
            {
                text_selected_subject.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(i);

            }
        }

        private void btn_mul_fwd_Click(object sender, EventArgs e)
        {
            foreach (string sub in listBox1.Items)
            {
                text_selected_subject.Items.Add(sub);
            }
            listBox1.Items.Clear();
        }

        private void btn_single_bkw_Click(object sender, EventArgs e)
        {
            int i = text_selected_subject.SelectedIndex;
            if (i == -1)
            {
                MessageBox.Show("Slect Subject to Move");
            }
            else
            {
                listBox1.Items.Add(text_selected_subject.SelectedItem);
                text_selected_subject.Items.RemoveAt(i);

            }
        }

        private void btn_mul_bkw_Click(object sender, EventArgs e)
        {
            foreach (string sub in text_selected_subject.Items)
            {
                listBox1.Items.Add(sub);
            }
            text_selected_subject.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
