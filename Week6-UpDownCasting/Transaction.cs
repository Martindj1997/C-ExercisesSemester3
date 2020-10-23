using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B_BankAccountMgr
{
    public enum TransactionType { DEPOSIT, WITHDRAWAL};
    public class Transaction
    {
        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            Type = type;
            Timestamp = DateTime.Now;
        }

        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public TransactionType Type { get; set; }

        public TransactionType TransactionType
        {
            get => default;
            set
            {
            }
        }

        public override string ToString()
        {
            return $"{Timestamp} {Type} {Amount}"; 
        }
    }
}
