using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}
