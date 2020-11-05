using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box_concept_using_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbSubjects.SelectedIndex != -1)
                MessageBox.Show(cbSubjects.SelectedItem.ToString());
            else
                MessageBox.Show("Select Subjects First");
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbSubjects.SelectedIndex.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbSubjects.SelectedIndex != -1)
                cbSubjects.Items.RemoveAt(cbSubjects.SelectedIndex);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string items = txtAdd.Text;
            if (txtAdd.Text != string.Empty)
            {
                if (cbSubjects.Items.Contains(items))
                    MessageBox.Show("Alraedy in List");
                else
                    cbSubjects.Items.Add(items);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bnRemSub_Click(object sender, EventArgs e)
        {

            if (rbIndexRemove.Checked)
            {
                if (txtRemoveItems.Text != string.Empty)
                {
                    int i = int.Parse(txtRemoveItems.Text);
                    cbSubjects.Items.RemoveAt(i);
                    MessageBox.Show("Index " + i + " Removed Successfully");
                }
                else
                    MessageBox.Show("Insert Index first");

            } // if end braclet close

            else if (rbValRemove.Checked) {
                if(txtRemoveItems.Text != string.Empty)
                {
                    String subject = txtRemoveItems.Text;
                    cbSubjects.Items.Remove(subject);
                    MessageBox.Show("Value " + subject + " Removed Successfully");
                }
                else
                    MessageBox.Show("Insert Value first");

            }
        }
    }
}
