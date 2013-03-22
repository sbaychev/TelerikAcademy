using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class LoanAccount : Account
    {
        public LoanAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)  { }

        public override decimal CalculateInterestRate(int numbMonths)
        {
            decimal currentRate = this.interestRate;
            if (this.Customer == CustomerType.Individual)
            {
                if (numbMonths - 3 < 0)
                {
                    currentRate = 0;
                }
                else
                {
                    currentRate = base.CalculateInterestRate(numbMonths - 3);
                }
            }
            else if (this.customer == CustomerType.Company)
            {
                if (numbMonths - 2 < 0)
                {
                    currentRate = 0;
                }
                else
                {
                    currentRate = base.CalculateInterestRate(numbMonths - 2);
                }
            }
            else
            {
                return 0;
            }
            return currentRate;
        }

        public override void Withdrawal(decimal amount)
        {
            throw new NotSupportedException("Loan accounts do not have withdrawal operation");
        }
    }
}