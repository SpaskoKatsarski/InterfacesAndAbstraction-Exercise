using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IReadOnlyCollection<Private> Privates => this.privates.AsReadOnly();

        public void AddPrivate(Private privateSoldier)
        {
            this.privates.Add(privateSoldier);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var prvt in this.Privates)
            {
                sb.AppendLine($"  {prvt.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
