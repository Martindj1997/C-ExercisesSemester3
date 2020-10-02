using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B_BankAccountMgr
{
    class Branch
    {
        public List<BankAccount> Accounts { get; set; }
        public string Name { get; set; }
        public int BranchNumber { get; set; }
    }
}
