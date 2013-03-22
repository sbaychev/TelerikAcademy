using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    abstract class Account
    {
        public enum CustomerType { Individual, Company };

        protected CustomerType customer;
        protected decimal balance;
        protected decimal interestRate;

        public Account(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public CustomerType Customer
        {
            get { return this.customer; }
        }

        public decimal Balance
        {
            get { return this.balance; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
        }

        public void Deposit(decimal amount)
        {
            this.balance = this.balance + amount;
        }

        public virtual decimal CalculateInterestRate(int numbMonths)
        {
            return this.interestRate * numbMonths;
        }

        public abstract void Withdrawal(decimal amount);
    }
}