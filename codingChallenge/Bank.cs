using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenge
{
    public class Bank : IBank
    {
        private string _name;
        private List<Account> _accounts;
        public string BankName { get => _name; set => _name = value; }
        public List<Account> BankAccounts { get => _accounts; set => _accounts = value; }
    }
}
