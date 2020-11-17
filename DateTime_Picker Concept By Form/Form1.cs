using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Picker_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime d = dateTimePicker1.Value;
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());

        }

        private void btn_break_ap_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            tb_day.Text = d.DayOfWeek.ToString();
            tb_date.Text = d.Date.ToString();
            tb_month.Text = d.Month.ToString();
            tb_year.Text = d.Year.ToString();
        }

        private void btn_add_month_Click(object sender, EventArgs e)
        {
            try
            {
                int add_months = int.Parse(tb_new_month.Text);
                DateTime d = dateTimePicker1.Value;
                if (add_months != null)
                {
                    d = d.AddMonths(add_months);
                    tb_new_date.Text = d.ToShortDateString();

                }
                else {
                    d = d.AddMonths(0);
                    tb_new_date.Text = d.ToShortDateString();
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
                
            }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            tb_age.Text = dateTimePicker1.Value.Subtract(dateTimePicker2.Value).TotalDays.ToString();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
