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

namespace Filing__via_form_LogFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text.Contains("0") || tb_name.Text.Contains("1") ||
                    tb_name.Text.Contains("2") || tb_name.Text.Contains("3") ||
                    tb_name.Text.Contains("4") || tb_name.Text.Contains("5") ||
                    tb_name.Text.Contains("6") || tb_name.Text.Contains("7") ||
                    tb_name.Text.Contains("8") || tb_name.Text.Contains("9"))
                {
                    throw new Exception("Invalid Name");
                }

                int id = int.Parse(tb_id.Text);
                double nic = double.Parse(tb_nic.Text);
                double phone = double.Parse(tb_phone.Text);

            }
            catch (Exception ex) {
                FileStream file = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                StreamWriter stream_writer = new StreamWriter(file);
                stream_writer.Write(DateTime.Now + "|" + ex.Message +"|" + "LogFileConcept ---> Save"+"~");
                stream_writer.Close();
                file.Close();

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
