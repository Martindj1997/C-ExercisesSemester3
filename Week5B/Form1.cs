using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text.Trim();
            if (name.Length < 1)
            {
                OutputResult(Color.Red, "Add name failed!  Name length must be at least 1 character");
                return;
            }
            namesLB.Items.Add(name);
            nameTB.Clear();
            OutputResult(Color.Green, "New name added successfully.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (namesLB.SelectedIndex == -1)
            {
                OutputResult(Color.Red, "Delete name failed!  No name is currently selected in the list.");
                return;
            }
            namesLB.Items.RemoveAt(namesLB.SelectedIndex);
            OutputResult(Color.Green, "Name deleted successfully.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (namesLB.Items.Count > 0)
            {
                //MessageBox.Show()
                namesLB.Items.Clear();
                OutputResult(Color.Green, "Name list cleared.");
            }
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {

        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {

        }

        private void OutputResult(Color color, string message)
        {
            resultLbl.Text = message;
            resultLbl.ForeColor = color;
        }

    }
}
