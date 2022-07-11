using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corp) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.repairs = new List<Repair>();
        }

        public IReadOnlyCollection<Repair> Repairs => this.repairs;

        public void AddRepair(Repair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:f2}");
            sb.AppendLine($"Corps: {base.Corps}");
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine("  " + repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
