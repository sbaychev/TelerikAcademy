using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class Worker : Human
    {
        private decimal weeklySalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal salary, decimal workHours)
            : base(firstName, lastName)
        {
            this.weeklySalary = salary;
            this.workHoursPerDay = workHours;
        }

        public decimal WeeklySalary
        {
            get { return this.weeklySalary; }
            set { this.weeklySalary = value; }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (weeklySalary) / (workHoursPerDay * 5);
            return result;
        }

        public override string ToString()
        {
            string result = string.Format("Student Name: {0} {1}   Salary Per Hour: {2:F2}Lv.", this.firstName, this.lastName, this.MoneyPerHour());
            return result;
        }
    }
}