using System;
using System.Collections.Generic;
using System.Text;

namespace T03.Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Browse(string url)
        {
            if (!IsUrlValid(url))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!IsNumberValid(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
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

        private bool IsUrlValid(string url)
        {
            foreach (var symbol in url)
            {
                if (char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
