using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_view_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_id.Text, txt_name.Text, txt_mark.Text, false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_mark.Text = string.Empty;
            txt_name.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {

                row = dataGridView1.Rows[i];

                if (Convert.ToBoolean(row.Cells[3].Value) == true) {

                    dataGridView1.Rows.RemoveAt(i);
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
