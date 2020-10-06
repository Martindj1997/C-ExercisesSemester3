using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B_BankAccountMgr
{
    class BankAccount
    {
        private static int number = 1000;
        public decimal Balance { get; private set; }
        protected int Number { get; set; }
        protected Person Owner { get; set; }
        public List<Transaction> Transactions { get; private set; }

        internal Person Person
        {
            get => default;
            set
            {
            }
        }

        public Transaction Transaction
        {
            get => default;
            set
            {
            }
        }

        public BankAccount(Person owner)
        {
            Number = number++;
            Owner = owner;
            Transactions = new List<Transaction>();
        }

        public Transaction Deposit(decimal amount)
        {
            Transaction transaction = new Transaction(amount, TransactionType.DEPOSIT);
            Transactions.Add(transaction);
            Balance += amount;
            return transaction;
        }

        public Transaction Withdraw(decimal amount)
        {
            Transaction transaction = new Transaction(amount, TransactionType.WITHDRAWAL);
            Transactions.Add(transaction);
            Balance -= amount;
            return transaction;
        }

        public override string ToString()
        {
            return $"{Number} {Owner} {Balance}";
        }
    }
}
