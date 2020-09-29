using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal monthlyFee = 0;

            // determine monthly base fee
            if (adultRB.Checked)
                monthlyFee = 40;
            else if (childRB.Checked)
                monthlyFee = 20;
            else if (studentRB.Checked)
                monthlyFee = 25;
            else if (seniorRB.Checked)
                monthlyFee = 30;

            // determine monthly optional services fee
            if (yogaCB.Checked)
                monthlyFee += 10;
            if (karateCB.Checked)
                monthlyFee += 30;
            if (trainerCB.Checked)
                monthlyFee += 50;

            // output the result
            monthlyFeeTB.Text = monthlyFee.ToString("C");
            decimal total = monthlyFee * monthsNUD.Value;
            totalTB.Text = total.ToString("C");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //reset and/or clear controls
            adultRB.Checked = true;
            yogaCB.Checked = false;
            karateCB.Checked = false;
            trainerCB.Checked = false;
            monthsNUD.Value = monthsNUD.Minimum;   //1;

            monthlyFeeTB.Clear(); // monthlyFeeTB.Text = string.Empty;
            totalTB.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
