using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class DepositAccount : Account
    {
        public DepositAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)  { }

        public override decimal CalculateInterestRate(int numbMonths)
        {
            decimal currentRate = this.interestRate;
            if (this.balance < 1000)
            {
                currentRate = 0;
            }
            else
            {
                currentRate = base.CalculateInterestRate(numbMonths);
            }
            return currentRate;
        }

        public override void Withdrawal(decimal amount)
        {
            this.balance = this.balance - amount;
        }
    }
}