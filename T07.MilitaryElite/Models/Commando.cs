using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<Mission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corp)
            : base(id, firstName, lastName, salary, corp)
        {
            this.missions = new List<Mission>();
        }

        public IReadOnlyCollection<Mission> Missions => this.missions;

        public void AddMission(Mission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:f2}");
            sb.AppendLine($"Corps: {base.Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in this.Missions.Where(m => m.State.ToLower() == "inprogress"))
            {
                sb.AppendLine("  " + mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
