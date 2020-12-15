using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");

        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                 con.Open();
                MessageBox.Show("SQL Connection Open");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "insert into StudentInfo (StudentID,StudentName) values (" + tb_id.Text + ", '" + tb_name.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Inserted");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
