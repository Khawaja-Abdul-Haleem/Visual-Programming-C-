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

namespace Insert_update_delete
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "INSERT INTO Products (ID, Name, Price) values ("+tb_id.Text+", '"+tb_name.Text+"', "+tb_priice.Text+")";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Inserted");

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
                string q = "UPDATE Products set Name = '"+tb_name.Text+"' , Price = "+tb_priice.Text+" where ID = "+tb_id.Text+"";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "delete from Products where ID = "+tb_id.Text+"";
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
