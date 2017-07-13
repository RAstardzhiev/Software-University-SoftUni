namespace Need_For_Speed___11_July_2017.Models.Races
{
    using Cars;
    using System.Linq;
    using System.Text;

    public class CircuitRace : Race
    {
        private new const double FirstPlaceMoneyPercentage = 0.4;
        private const double FourthPlaceMoneyPercentage = 0.1;

        private int laps;

        public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
        {
            this.laps = laps;
        }

        protected override int GetPerformancePoints(Car car) => (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length * this.laps}");

            foreach (var car in this.Participants)
            {
                car.DecreaseDurabilityDueToCircuitRace(this.laps, this.Length);
            }

            var winners = this.Participants
                .Select(c => new
                {
                    Car = c,
                    Points = this.GetPerformancePoints(c)
                })
                .OrderByDescending(obj => obj.Points)
                .Take(4)
                .ToArray();

            for (int i = 0; i < winners.Length; i++)
            {
                var moneyWon = i == 0
                    ? (int)(this.PrizePool * FirstPlaceMoneyPercentage)
                    : i == 1
                    ? (int)(this.PrizePool * SecondPlaceMoneyPercentage)
                    : i == 2
                    ? (int)(this.PrizePool * ThirdPlaceMoneyPercentage)
                    : (int)(this.PrizePool * FourthPlaceMoneyPercentage);

                sb.AppendLine($"{i + 1}. {winners[i].Car.Brand} {winners[i].Car.Model} {winners[i].Points}PP - ${moneyWon}");
            }

            return sb.ToString().Trim();
        }
    }
}