using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public interface IAccount
    {
        AccountTypes AccountType { get; set; }
        string AccountOwner { get; set; }
        decimal AccountBalance { get; set; }

        void Transaction(TransactionTypes type, decimal amount);
        void Transaction(TransactionTypes type, decimal amount, Account fromAccount, Account toAccount);
        void MakeDeposit(decimal amount);
        void MakeWithdrawal(decimal amount);
        void MakeTransfer(decimal amount, Account fromAccount, Account toAccount);
    }
}
