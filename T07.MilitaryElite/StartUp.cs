using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var privates = new List<Private>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var cmdArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var soldierType = cmdArgs[0];
                string id = cmdArgs[1];
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];
                decimal salary;

                switch (soldierType)
                {
                    case "Private":
                        salary = decimal.Parse(cmdArgs[4]);

                        var privateSoldier = new Private(id, firstName, lastName, salary);
                        privates.Add(privateSoldier);
                        Console.WriteLine(privateSoldier);
                        break;
                    case "LieutenantGeneral":
                        salary = decimal.Parse(cmdArgs[4]);
                        var leutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                        if (cmdArgs.Length >= 5)
                        {
                            for (var i = 5; i < cmdArgs.Length; i++)
                            {
                                string privateId = cmdArgs[i];
                                privateSoldier = privates.FirstOrDefault(p => p.Id == privateId);

                                leutenantGeneral.AddPrivate(privateSoldier);
                            }
                        }
                        Console.WriteLine(leutenantGeneral);
                        break;
                    case "Engineer":
                        salary = decimal.Parse(cmdArgs[4]);

                        if (cmdArgs[5].ToLower() != "airforces" && cmdArgs[5].ToLower() != "marines")
                        {
                            continue;
                        }

                        var engineer = new Engineer(id, firstName, lastName, salary, cmdArgs[5]);

                        if (cmdArgs.Length >= 6)
                        {
                            for (var i = 6; i < cmdArgs.Length; i += 2)
                            {
                                var repairPartName = cmdArgs[i];
                                var repairHours = int.Parse(cmdArgs[i + 1]);

                                var repair = new Repair(repairPartName, repairHours);
                                engineer.AddRepair(repair);
                            }
                        }

                        Console.WriteLine(engineer);
                        break;
                    case "Commando":
                        salary = decimal.Parse(cmdArgs[4]);

                        if (cmdArgs[5].ToLower() != "airforces" && cmdArgs[5].ToLower() != "marines")
                        {
                            continue;
                        }

                        var commando = new Commando(id, firstName, lastName, salary, cmdArgs[5]);

                        if (cmdArgs.Length >= 6)
                        {
                            for (var i = 6; i < cmdArgs.Length; i += 2)
                            {
                                var missionName = cmdArgs[i];
                                var missionState = cmdArgs[i + 1];

                                if (missionState.ToLower() != "inprogress" && missionState.ToLower() != "finished")
                                {
                                    continue;
                                }

                                var mission = new Mission(missionName, missionState);
                                commando.AddMission(mission);
                            }
                            Console.WriteLine(commando);
                        }

                        break;
                    case "Spy":
                        var codeNumber = int.Parse(cmdArgs[4]);

                        var spy = new Spy(id, firstName, lastName, codeNumber);
                        Console.WriteLine(spy);
                        break;
                    default:
                        throw new Exception("Invalid soldier!");
                }
            }
        }
    }
}
