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


namespace Search_In_DataBase
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Students;Data Source=HAIER-PC\\KAHSQL");
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string q = "select * from Products where Name like '%"+tb_search.Text+"%'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader reader =  cmd.ExecuteReader();
                dgv1.Rows.Clear(); // if not use previous records still showen
                while (reader.Read())
                {
                    dgv1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());

                }
                reader.Close();
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
