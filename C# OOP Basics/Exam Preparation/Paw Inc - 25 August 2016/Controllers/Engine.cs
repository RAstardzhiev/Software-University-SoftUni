namespace Paw_Inc___25_August_2016.Controllers
{
    using System;

    public class Engine
    {
        private PawIncManager manager;

        public Engine()
        {
            this.manager = new PawIncManager();
        }

        public void Start()
        {
            var command = Console.ReadLine();

            while (command != "Paw Paw Pawah")
            {
                if (command == "CastrationStatistics")
                {
                    Console.WriteLine(this.manager.PrintCastrationCentersStat());

                    command = Console.ReadLine();
                    continue;
                }

                var cmdArgs = command.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                var name = cmdArgs[1];
                int age;
                string adoptionCenterName;

                switch (cmdArgs[0])
                {
                    case "RegisterCleansingCenter": // RegisterCleansingCenter  | {name}
                        this.manager.RegisterCleansingCenter(name);
                        break;
                    case "RegisterAdoptionCenter": // RegisterAdoptionCenter | {name}
                        this.manager.RegisterAdoptionCenter(name);
                        break;
                    case "RegisterCastrationCenter": // RegisterCastrationCenter | {name}
                        this.manager.RegisterCastrationCenter(name);
                        break;
                    case "RegisterDog": // RegisterDog | {name} | {age} | {learnedCommands} | {adoptionCenterName}
                        age = int.Parse(cmdArgs[2]);
                        var learnedCommands = int.Parse(cmdArgs[3]);
                        adoptionCenterName = cmdArgs[4];
                        this.manager.RegisterDog(name, age, learnedCommands, adoptionCenterName);
                        break;
                    case "RegisterCat": // RegisterCat | {name} | {age| | {intelligenceCoefficient} | {adoptionCenterName}
                        age = int.Parse(cmdArgs[2]);
                        var intelligenceCoefficient = int.Parse(cmdArgs[3]);
                        adoptionCenterName = cmdArgs[4];
                        this.manager.RegisterCat(name, age, intelligenceCoefficient, adoptionCenterName);
                        break;
                    case "SendForCleansing": // SendForCleansing | {adoptionCenterName} | {cleansingCenterName}
                        adoptionCenterName = cmdArgs[1];
                        var cleansingCenterName = cmdArgs[2];
                        this.manager.SendForCleansing(adoptionCenterName, cleansingCenterName);
                        break;
                    case "Cleanse": // Cleanse | {cleansingCenterName}
                        this.manager.Cleanse(name);
                        break;
                    case "Adopt": // Adopt | {adoptionCenterName}
                        this.manager.Adopt(name);
                        break;
                    case "Castrate": // Castrate | {castrationCenterName}
                        this.manager.Castrate(name);
                        break;
                    case "SendForCastration": // SendForCastration | {adoptionCenterName} | {castrationCenterName}
                        adoptionCenterName = cmdArgs[1];
                        var castrationCenterName = cmdArgs[2];
                        this.manager.SendForCastration(adoptionCenterName, castrationCenterName);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.Write(this.manager);
        }
    }
}
