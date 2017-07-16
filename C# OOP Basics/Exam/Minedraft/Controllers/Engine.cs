namespace Minedraft.Controllers
{
    using System;
    using System.Linq;

    public class Engine
    {
        private DraftManager manager;

        public Engine()
        {
            this.manager = new DraftManager();
        }

        public void Run()
        {
            while (true)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "RegisterHarvester":
                        Console.WriteLine(this.manager.RegisterHarvester(command.Skip(1).ToList()));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(this.manager.RegisterProvider(command.Skip(1).ToList()));
                        break;
                    case "Day":
                        Console.WriteLine(this.manager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(this.manager.Mode(command.Skip(1).ToList()));
                        break;
                    case "Check":
                        Console.WriteLine(this.manager.Check(command.Skip(1).ToList()));
                        break;
                    case "Shutdown":
                        Console.WriteLine(this.manager.ShutDown());
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
