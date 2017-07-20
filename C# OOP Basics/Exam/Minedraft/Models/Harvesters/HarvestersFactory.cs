namespace Minedraft.Models.Harvesters
{
    using System.Collections.Generic;

    public class HarvesterFactory
    {
        public Harvester RegisterHarvester(string id, double oreOutput, double energyRequirement)
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }

        public Harvester RegisterHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        {
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }

        internal Harvester RegisterHarvester(List<string> arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);

            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                return this.RegisterHarvester(id, oreOutput, energyRequirement, sonicFactor);
            }
            else
            {
                return this.RegisterHarvester(id, oreOutput, energyRequirement);
            }
        }
    }
}
