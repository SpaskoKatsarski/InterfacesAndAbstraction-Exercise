using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IBuyer : INameable
    {
        void BuyFood();

        int Food { get; }
    }
}
