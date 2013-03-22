using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Bank
    {
        private List<Account> accounts;
        private int accountsCount;

        public Bank()
        {
            this.accounts = new List<Account>();
            this.accountsCount = 0;
        }

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
            this.accountsCount = this.accounts.Count;
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
        }

        public int AccountsCount
        {
            get { return this.accountsCount; }
        }

        public void AddAccount(Account newAccount)
        {
            this.accounts.Add(newAccount);
            this.accountsCount++;
        }

        public void RemoveAccount(Account remAccount)
        {
            this.accounts.Remove(remAccount);
            this.accountsCount--;
        }
    }
}