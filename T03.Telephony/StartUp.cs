using System;
using System.Collections.Generic;

namespace T03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ICallable phone = null;

            try
            {
                foreach (string phoneNumber in phoneNumbers)
                {
                    if (phoneNumber.Length == 10)
                    {
                        phone = new Smartphone();
                        Console.WriteLine(phone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        phone = new StationaryPhone();
                        Console.WriteLine(phone.Call(phoneNumber));
                    }
                }

                IBrowseable brPhone;
                foreach (var url in urls)
                {
                    brPhone = new Smartphone();
                    Console.WriteLine(brPhone.Browse(url));
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
