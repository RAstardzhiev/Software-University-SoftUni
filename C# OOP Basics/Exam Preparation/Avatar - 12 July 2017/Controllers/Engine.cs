namespace Avatar___12_July_2017.Controllers
{
    using System;
    using System.Linq;

    public class Engine
    {
        private NationsBuilder nationsBuilder;

        public Engine()
        {
            this.nationsBuilder = new NationsBuilder();
        }

        public void Start()
        {
            var command = Console.ReadLine().Split();

            while (command[0] != "Quit")
            {
                switch (command[0])
                {
                    case "Bender":
                        this.nationsBuilder.AssignBender(command.Skip(1).ToList());
                        break;
                    case "Monument":
                        this.nationsBuilder.AssignMonument(command.Skip(1).ToList());
                        break;
                    case "Status":
                        var status = this.nationsBuilder.GetStatus(command[1]);
                        Console.WriteLine(status);
                        break;
                    case "War":
                        var nation = command[1];
                        this.nationsBuilder.IssueWar(nation);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(this.nationsBuilder.GetWarsRecord());
        }
    }
}
