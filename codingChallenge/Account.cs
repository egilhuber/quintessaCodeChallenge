using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public class Account : IAccount
    {
        public Account(AccountTypes type, string owner, decimal balance)
        {
            AccountType = type;
            AccountOwner = owner;
            AccountBalance = balance;
        }

        private AccountTypes _type;
        private string _owner;
        private decimal _balance;

        public AccountTypes AccountType { get => _type; set => _type = value; }
        public string AccountOwner { get => _owner; set => _owner = value; }
        public decimal AccountBalance { get => _balance; set => _balance = value; }

        public void Transaction(TransactionTypes type, decimal amount)
        {
            switch (type)
            {
                case TransactionTypes.Deposit:
                    MakeDeposit(amount);
                    break;
                case TransactionTypes.Withdrawal:
                    MakeWithdrawal(amount);
                    break;
                case TransactionTypes.Transfer:
                    throw new Exception();
                default:
                    break;
            }
        }

        public void Transaction(TransactionTypes type, decimal amount, Account fromAccount, Account toAccount)
        {
            switch (type)
            {
                case TransactionTypes.Deposit:
                    MakeDeposit(amount);
                    break;
                case TransactionTypes.Withdrawal:
                    MakeWithdrawal(amount);
                    break;
                case TransactionTypes.Transfer:
                    MakeTransfer(amount, fromAccount, toAccount);
                    break;
                default:
                    break;
            }
        }

        public void MakeDeposit(decimal amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void MakeWithdrawal(decimal amount)
        {
            if (AccountType == AccountTypes.IndividualInvestment && amount > 500)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (amount <= AccountBalance)
            {
                AccountBalance -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void MakeTransfer(decimal amount, Account fromAccount, Account toAccount)
        {
            if (amount > 0)
            {
                fromAccount.AccountBalance -= amount;
                toAccount.AccountBalance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
