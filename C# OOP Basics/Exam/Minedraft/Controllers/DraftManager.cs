namespace Minedraft.Controllers
{
    using Models.Harvesters;
    using Models.Providers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DraftManager
    {
        private List<Harvester> harvesters;
        private List<Provider> providers;
        private double producedEnergy;
        private double producedOre;
        private string mode;
        private HarvesterFactory harvesterFactory;
        private ProviderFactory providerFactory;

        public DraftManager()
        {
            this.harvesters = new List<Harvester>();
            this.providers = new List<Provider>();
            this.mode = "Full";
            this.harvesterFactory = new HarvesterFactory();
            this.providerFactory = new ProviderFactory();
        }

        public string RegisterHarvester(List<string> arguments)
        {
            try
            {
                this.harvesters.Add(this.harvesterFactory.RegisterHarvester(arguments));
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }

            var type = arguments[0];
            var id = arguments[1];

            return $"Successfully registered {type} Harvester - {id}";
        }

        public string RegisterProvider(List<string> arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var energy = double.Parse(arguments[2]);

            try
            {
                this.providers.Add(this.providerFactory.RegisterProvider(type, id, energy));
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }

            return $"Successfully registered {type} Provider - {id}";
        }

        public string Day()
        {
            var energy = this.providers.Select(p => p.EnergyOutput).Sum();
            var neededEnergy = this.harvesters.Select(h => h.EnergyRequirement).Sum();
            var ores = this.harvesters.Select(h => h.OreOutput).Sum();
            this.producedEnergy += energy;

            if (this.mode == "Half")
            {
                neededEnergy *= 0.6;
                ores *= 0.5;
            }

            var stat = new StringBuilder();
            stat.AppendLine("A day has passed.")
                    .AppendLine($"Energy Provided: {energy}");

            if (this.mode == "Energy" || this.producedEnergy < neededEnergy)
            {
                stat.AppendLine($"Plumbus Ore Mined: 0");
                return stat.ToString().Trim();
            }

            this.producedEnergy -= neededEnergy;
            this.producedOre += ores;

            stat.AppendLine($"Plumbus Ore Mined: {ores}");
            return stat.ToString().Trim();
        }

        public string Mode(List<string> arguments)
        {
            this.mode = arguments.First();
            return $"Successfully changed working mode to {mode} Mode";
        }

        public string Check(List<string> arguments)
        {
            var currentHarvest = this.harvesters.FirstOrDefault(h => h.Id == arguments[0]);
            Provider currentProvider = null;

            if (currentHarvest == null)
            {
                currentProvider = this.providers.FirstOrDefault(p => p.Id == arguments[0]);
            }
            else
            {
                return currentHarvest.ToString();
            }

            if (currentProvider == null)
            {
                return $"No element found with id - {arguments[0]}";
            }

            return currentProvider.ToString();
        }

        public string ShutDown()
        {
            var sb = new StringBuilder();
            sb.AppendLine("System Shutdown")
                .AppendLine($"Total Energy Stored: {this.producedEnergy}")
                .AppendLine($"Total Mined Plumbus Ore: {this.producedOre}");

            return sb.ToString().Trim();
        }
    }
}
