using System;
using System.Collections.Generic;
using System.Text;

namespace T03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!IsNumberValid(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }

        private bool IsNumberValid(string phoneNum)
        {
            foreach (var digit in phoneNum)
            {
                if (char.IsLetter(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
