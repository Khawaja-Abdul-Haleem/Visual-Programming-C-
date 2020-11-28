using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Grid_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("Select Degree");
                comboBox1.Focus();
                return;
            }
            // textBox1.Text.Trim() == string.Empty
                    // or
            if (string.IsNullOrEmpty(textBox1.Text)) {
                MessageBox.Show("Enter % marks");
                textBox1.Focus();
                return;
            }
            string deg = comboBox1.SelectedItem.ToString();
            string mar = textBox1.Text;
            try {
                float f = float.Parse(mar);
                dataGridView1.Rows.Add(deg, mar);
            
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
