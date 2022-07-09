using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public interface IPerson
    {
        int Age { get; }

        int Default => 2;
    }
}
