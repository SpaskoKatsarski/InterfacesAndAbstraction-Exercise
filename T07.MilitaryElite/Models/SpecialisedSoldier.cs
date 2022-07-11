using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corp) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corp;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if (value.ToLower() == "airforces" || value.ToLower() == "marines")
                {
                    this.corps = value;
                }
            }
        } //Airforces or Marines
    }
}
