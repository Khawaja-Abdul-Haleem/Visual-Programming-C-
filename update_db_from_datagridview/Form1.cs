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

namespace insert_from_gridvieew_to_db
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand cmd;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
            dt = new DataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string q = "select * from StudentInfo";
                cmd = new SqlCommand(q, con);
                adp = new SqlDataAdapter(cmd);

                SqlCommandBuilder cmd_build = new SqlCommandBuilder(adp);
                adp.Update(dt);
                dt.AcceptChanges();
                MessageBox.Show("Updated On Database Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string q = "select * from StudentInfo";
                cmd = new SqlCommand(q, con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
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
