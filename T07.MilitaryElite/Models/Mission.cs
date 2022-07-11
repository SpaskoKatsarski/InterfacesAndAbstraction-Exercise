using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }

        public string State 
        {
            get
            {
                return this.state;
            } 
            private set
            {
                if (value.ToLower() == "inprogress" || value.ToLower() == "finished")
                {
                    this.state = value;
                }
            } 
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Code Name: {this.CodeName} State: {this.State}");

            return sb.ToString().TrimEnd();
        }
    }
}
