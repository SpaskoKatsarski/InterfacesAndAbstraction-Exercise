using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] buyerInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (buyerInfo.Length == 4)
                {
                    //Citizen
                    buyers.Add(new Citizen(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2], buyerInfo[3]));
                }
                else if (buyerInfo.Length == 3)
                {
                    buyers.Add(new Rebel(buyerInfo[0], int.Parse(buyerInfo[1]), buyerInfo[2]));
                }
            }

            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                if (!buyers.Any(b => b.Name == name))
                {
                    continue;
                }

                buyers.First(b => b.Name == name).BuyFood();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
