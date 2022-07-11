using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        private decimal salary;

        public Private(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value >= 0)
                {
                    this.salary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary:f2}";
        }
    }
}
