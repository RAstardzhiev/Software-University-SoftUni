namespace Minedraft.Models.Providers
{
    public class PressureProvider : Provider
    {
        private const double PercentageEnergyOutputIncreasement = 1.5;

        public PressureProvider(string id, double energyOutput)
            : base(id, IncreasedEnergy(energyOutput))
        {
        }

        private static double IncreasedEnergy(double energyOutput) => energyOutput * PercentageEnergyOutputIncreasement;
    }
}
