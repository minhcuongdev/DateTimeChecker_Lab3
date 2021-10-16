using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        DTChecker dtChecker;

        public DTChecker DtChecker { get => dtChecker; set => dtChecker = value; }

        public Form1()
        {
            InitializeComponent();
            DtChecker = new DTChecker();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtDay.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int err = 0;
            err = DtChecker.CheckFormatInput(txtDay.Text, txtMonth.Text, txtYear.Text);

            switch(err)
            {
                case 1:
                    MessageBox.Show("Input day for Day is incorrect format !");
                    break;
                case 2:
                    MessageBox.Show("Input day for Month is incorrect format !");
                    break;
                case 3:
                    MessageBox.Show("Input day for Year is incorrect format !");
                    break;
                default:
                    break;
            }

            if (err != 0) return;

            err = DtChecker.CheckRangeInput(int.Parse(txtDay.Text), int.Parse(txtMonth.Text), int.Parse(txtYear.Text));

            switch (err)
            {
                case 1:
                    MessageBox.Show("Input day for Day is out of range !");
                    break;
                case 2:
                    MessageBox.Show("Input day for Month is out of range !");
                    break;
                case 3:
                    MessageBox.Show("Input day for Year is out of range !");
                    break;
                default:
                    break;
            }

            if (err != 0) return;

            if (DtChecker.IsValidDay(int.Parse(txtDay.Text), int.Parse(txtMonth.Text), int.Parse(txtYear.Text)))
            {
                MessageBox.Show("dd/mm/yy is correct date time !");
            }
            else
            {
                MessageBox.Show("dd/mm/yy is NOT correct date time !");
            }
        }
    }
}
