using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4B_BankAccountMgr
{
    public partial class Form1 : Form
    {
        private Branch branch;
        public Form1()
        {
            InitializeComponent();
        }

    
        //internal Branch Branch
        //{
        //    get => default;
        //    set
        //    {
        //        branch = value;
        //    }
        //}

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // get and validate input
            if (firstTB.TextLength < 2 || lastTB.TextLength < 2)
            {
                resultLbl.Text = "Create account denied!  First and last names must have at least 2 characters.";
                resultLbl.ForeColor = Color.Red;
                return;
            }

            Person owner = new Person(firstTB.Text, lastTB.Text);
            BankAccount account;

            if (chequingRB.Checked)
                account = new ChequingAccount(owner);
            else // if (savingsRB.Check)
                account = new SavingsAccount(owner);

            // add new account to the branch and listbox
            branch.Accounts.Add(account);
            accountsLB.Items.Add(account);

            // update result label
            resultLbl.Text = "Create account successful!";
            resultLbl.ForeColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            branch = new Branch("Mohawk College");
        }
    }
}
