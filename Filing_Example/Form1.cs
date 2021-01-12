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

namespace Filing_Example_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("my_file.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader stream_reader = new StreamReader(file);
            textBox1.Text =  stream_reader.ReadToEnd();
            stream_reader.Close();
            file.Close();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("my_file.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter stream_writer = new StreamWriter(file);
            stream_writer.Write(textBox1.Text);
            stream_writer.Flush();
            stream_writer.Close();
            file.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
