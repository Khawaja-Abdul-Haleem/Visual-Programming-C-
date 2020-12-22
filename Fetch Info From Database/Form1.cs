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

namespace fetch_insert_delete_info_from_DB
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "select Name, Price from Products WHERE ID = "+tb_id.Text+"";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tb_name.Text = reader.GetValue(0).ToString();
                    tb_price.Text = reader.GetValue(1).ToString();
                    btn_insert.Enabled = false;
                    tb_id.Enabled = false;
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_price.Text = "";
            btn_insert.Enabled = true;
            tb_id.Enabled = true;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "INSERT INTO Products (ID, Name, Price) values (" + tb_id.Text + ", '" + tb_name.Text + "', " +tb_price.Text+ ")";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Inserted");

            }
            catch (Exception ex)
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
                string q = "UPDATE Products set Name = '" + tb_name.Text + "' , Price = " + tb_price.Text + " where ID = " + tb_id.Text + "";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "delete from Products where ID = " + tb_id.Text + "";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Deleted");
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
