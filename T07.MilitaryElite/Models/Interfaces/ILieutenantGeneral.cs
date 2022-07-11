using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
