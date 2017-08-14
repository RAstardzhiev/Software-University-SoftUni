namespace _02.Kings_Gambit.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Interfaces;

    public class Engine
    {
        private King king;
        private List<Soldier> soldiers;

        private IReader reader;
        private IWroiter writer;

        public Engine(IReader reader, IWroiter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.soldiers = new List<Soldier>();
        }

        public void Run()
        {
            this.BuildKingdom();
            this.ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            var command = this.reader.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        this.king.OnUnderAttack();
                        break;
                    case "Kill":
                        this.RemoveDeadSoldier(command[1]);
                        break;
                    default:
                        break;
                }

                command = this.reader.ReadLine().Split();
            }
        }

        private void RemoveDeadSoldier(string soldierName)
        {
            var soldier = this.soldiers.FirstOrDefault(s => s.Name == soldierName);
            king.UnderAttack -= soldier.KingUnderAttack;
            this.soldiers.Remove(soldier);
        }

        private void BuildKingdom()
        {
            var kingName = this.reader.ReadLine();
            this.king = new King(kingName, this.writer);

            var royalGuardNames = this.reader.ReadLine().Split();
            foreach (var name in royalGuardNames)
            {
                var royalGuard = new RoyalGuard(name, this.writer);
                this.soldiers.Add(royalGuard);
                this.king.UnderAttack += royalGuard.KingUnderAttack;
            }

            var footmanNames = this.reader.ReadLine().Split();
            foreach (var name in footmanNames)
            {
                var footman = new Footman(name, this.writer);
                this.soldiers.Add(footman);
                this.king.UnderAttack += footman.KingUnderAttack;
            }
        }
    }
}
