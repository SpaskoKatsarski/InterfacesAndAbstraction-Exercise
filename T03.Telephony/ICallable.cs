using System;
using System.Collections.Generic;
using System.Text;

namespace T03.Telephony
{
    public interface ICallable
    {
        string Call(string number);
    }
}
