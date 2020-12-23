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

namespace Database_Diconnected_Approach
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds;
       // DataTable dt;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
            ds = new DataSet(); // we can use dataset and datatable
            //for single table use
            // dt = new Datatable();

      // Note:  ds is used for multiple tables

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dr = ds.Tables[0].Select("StudentName like '%" + tb_search.Text + "%' ");
                dataGridView1.Rows.Clear();
                foreach (DataRow r in dr)
                {
                    dataGridView1.Rows.Add(r[0].ToString(), r[1].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_get_data_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string q = "select * from StudentInfo";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                con.Close();
            }
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
