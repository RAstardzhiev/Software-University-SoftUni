namespace _02.Blobs.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using Entities;
    using Interfaces;

    public class Engine
    {
        private IInputReader reader;
        private IOutputWriter writer;
        private ITypesCollector typeCollector;
        private MethodInfo[] methods;
        private bool isBattlePrintable;

        private Type[] attacks;
        private Type[] behaviors;
        private IList<IBlob> blobs;

        public Engine(IInputReader reader, IOutputWriter writer, ITypesCollector typeCollector)
        {
            this.reader = reader;
            this.writer = writer;
            this.typeCollector = typeCollector;
            this.methods = this.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            this.attacks = this.typeCollector.GetAbstractionsAllChildrent<IAttack>();
            this.behaviors = this.typeCollector.GetAbstractionsAllChildrent<IBehavior>();
            this.blobs = new List<IBlob>();
        }

        public void Run()
        {
            this.ExecuteCommand();
        }

        private void ExecuteCommand()
        {
            var input = this.reader.ReadLine().Split();
            if (input[0] == "report-events")
            {
                this.isBattlePrintable = true;
                input = this.reader.ReadLine().Split();
            }

            while (input[0] != "drop")
            {
                var command = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input[0].ToLower());
                var methodForExecution = this.methods.FirstOrDefault(m => m.Name == command);
                if (methodForExecution == null)
                {
                    throw new ArgumentException("Undefined command");
                }

                methodForExecution.Invoke(this, new object[] { input.Skip(1).ToArray() });
                this.Update();

                input = this.reader.ReadLine().Split();
            }
        }

        private void Create(string[] cmdArgs)
        {
            var name = cmdArgs[0];
            var health = int.Parse(cmdArgs[1]);
            var damage = int.Parse(cmdArgs[2]);
            var behaviorName = cmdArgs[3];
            var attackName = cmdArgs[4];

            var behavior = (IBehavior)Activator.CreateInstance(this.behaviors.FirstOrDefault(b => b.Name == behaviorName));
            var attack = (IAttack)Activator.CreateInstance(this.attacks.FirstOrDefault(a => a.Name == attackName));
            if (attack == null || behavior == null)
            {
                return;
            }

            this.blobs.Add(new Blob(name, health, damage, behavior, attack));
        }

        private void Attack(string[] cmdArgs)
        {
            var attackerName = cmdArgs[0];
            var targetName = cmdArgs[1];

            var attacker = this.blobs.FirstOrDefault(b => b.Name == attackerName);
            var target = this.blobs.FirstOrDefault(b => b.Name == targetName);
            if (attacker == null || attacker.Health <= 0 || 
                target == null || target.Health <= 0)
            {
                return;
            }

            this.ProcessBattle(attacker, target);
        }

        private void Status(string[] cmdArgs) 
            => this.writer.WriteLine(string.Join(Environment.NewLine, this.blobs));

        private void Pass(params string[] args)
        {
        }

        private void ProcessBattle(IBlob attacker, IBlob target)
        {
            attacker.Attack.Execute(attacker, target);

            if (attacker.IsTriggerMessageAvailable)
            {
                attacker.IsTriggerMessageAvailable = false;

                if (this.isBattlePrintable)
                {
                    this.writer.WriteLine($"Blob {attacker.Name} toggled {attacker.Behavior.GetType().Name}Behavior");
                }
            }

            if (target.IsTriggerMessageAvailable)
            {
                target.IsTriggerMessageAvailable = false;

                if (this.isBattlePrintable)
                {
                    this.writer.WriteLine($"Blob {target.Name} toggled {target.Behavior.GetType().Name}Behavior");
                }
            }

            if (this.isBattlePrintable && target.Health <= 0)
            {
                this.writer.WriteLine($"Blob {target.Name} was killed");
            }
        }

        private void Update()
        {
            foreach (var blob in this.blobs.Where(b => b.Behavior.IsTriggered))
            {
                blob.MakeATurn();
            }
        }
    }
}
