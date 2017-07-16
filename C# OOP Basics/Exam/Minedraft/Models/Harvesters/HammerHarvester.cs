namespace Minedraft.Models.Harvesters
{
    public class HammerHarvester : Harvester
    {
        private const int OreOutputMultiplication = 3;
        private const int EnergyRequirementMultiplication = 2;

        public HammerHarvester(string id, double oreOutput, double energyRequirement)
            : base(id, IncreasedOre(oreOutput), IncreasedEnergy(energyRequirement))
        {
        }

        private static double IncreasedEnergy(double energyRequirement) => energyRequirement * EnergyRequirementMultiplication;

        private static double IncreasedOre(double oreOutput) => oreOutput * OreOutputMultiplication;
    }
}