using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_DataGrid_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(txt_id.Text);
                string name = txt_name.Text;
                double contact = double.Parse(txt_contact.Text);
                dataGridView1.Rows.Add(id, name, contact);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            try
            {

                if (col == 3)
                {
                   dataGridView1.Rows[row].Cells[0].Value = txt_id.Text;
                   dataGridView1.Rows[row].Cells[1].Value = txt_name.Text;
                   dataGridView1.Rows[row].Cells[2].Value = txt_contact.Text;

                }
            }//try bracket end
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
