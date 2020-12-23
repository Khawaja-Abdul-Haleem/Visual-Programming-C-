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

namespace update_data_in_Database_from_Locally
{
    
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
            ds = new DataSet();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

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

                dataGridView1.DataSource = ds.Tables[0];

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows.Add(tb_id.Text, tb_name.Text);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string q = "select * from StudentInfo";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                SqlCommandBuilder cmd_build = new SqlCommandBuilder(adp);
                adp.Update(ds.Tables[0]);
                ds.Tables[0].AcceptChanges();
                MessageBox.Show("Updated On DataBase SuccessFully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
