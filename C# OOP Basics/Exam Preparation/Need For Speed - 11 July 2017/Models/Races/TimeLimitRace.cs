namespace Need_For_Speed___11_July_2017.Models.Races
{
    using Cars;
    using System.Text;

    public class TimeLimitRace : Race
    {
        private const int EvaluationTimeSpan = 15;
        private const double GoldTimePrizePercentage = 1;
        private const double SilverTimePrizePercentage = 0.5;
        private const double BronzeTimePrizePercentage = 0.3;

        private int goldTime;

        public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
        {
            this.goldTime = goldTime;
        }

        protected override int GetPerformancePoints(Car car)
        {
            return this.Length * ((car.HorsePower / 100) * car.Acceleration);
        }

        private string GetEarnedTime(int timePerformance)
        {
            if (timePerformance <= this.goldTime)
            {
                return "Gold";
            }

            var silverTime = this.goldTime + EvaluationTimeSpan;
            if (timePerformance <= silverTime)
            {
                return "Silver";
            }

            return "Bronze";
        }

        public override string ToString()
        {
            var car = this.Participants[0];
            var timePerformance = this.GetPerformancePoints(car);
            var earnedTime = this.GetEarnedTime(timePerformance);
            var prizeWon = earnedTime == "Gold"
                ? (int)(this.PrizePool * GoldTimePrizePercentage)
                : earnedTime == "Silver"
                ? (int)(this.PrizePool * SilverTimePrizePercentage)
                : (int)(this.PrizePool * BronzeTimePrizePercentage);

            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}")
                .AppendLine($"{car.Brand} {car.Model} - {timePerformance} s.")
                .AppendLine($"{earnedTime} Time, ${prizeWon}.");

            return sb.ToString().Trim();
        }
    }
}