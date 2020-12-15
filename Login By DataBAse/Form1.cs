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

namespace Login
{
    
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "select * from Users where LoginName = '"+tb_user_name.Text+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader reader =  cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[1].ToString() == tb_pass.Text)
                    {
                        MessageBox.Show("Welcome " + tb_user_name.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
                reader.Close();
                con.Close();

            }catch(Exception ex)
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
