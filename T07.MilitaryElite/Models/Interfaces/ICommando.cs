﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }
    }
}
