using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_LogFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult dial = openFileDialog1.ShowDialog();
            if (dial == DialogResult.OK)
            {
                tb_path.Text = openFileDialog1.FileName;

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(tb_path.Text, FileMode.Open, FileAccess.Read);
            StreamReader s_d = new StreamReader(file);

            string log = s_d.ReadLine();
            string [] strline =  log.Split('~'); // break each record

            foreach (string s in strline) {
                if (!string.IsNullOrEmpty(s))
                {
                    string[] records = s.Split('|'); //break each columns
                    dataGridView1.Rows.Add(records[0], records[1], records[2]);
                }
                s_d.Close();
                file.Close();
            }
        }
    }
}
