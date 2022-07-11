using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                IPerson person = new Citizen(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
