using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    protected const double FirstPlaceMoneyPercentage = 0.5;
    protected const double SecondPlaceMoneyPercentage = 0.3;
    protected const double ThirdPlaceMoneyPercentage = 0.2;

    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    protected int PrizePool => this.prizePool;

    public IReadOnlyList<Car> Participants => this.participants as IReadOnlyList<Car>;

    public void RegisterCar(Car car)
    {
        this.participants.Add(car);
    }

    protected abstract int GetPerformancePoints(Car car);

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.route} - {this.length}");

        var winners = this.Participants
            .Select(c => new
            {
                Car = c,
                PerformancePoints = GetPerformancePoints(c)
            })
            .OrderByDescending(obj => obj.PerformancePoints)
            .Take(3)
            .ToArray();

        for (int i = 0; i < winners.Length; i++)
        {
            sb.Append($"{i + 1}. ")
                .Append($"{winners[i].Car.Brand} ")
                .Append($"{winners[i].Car.Model} ")
                .Append($"{winners[i].PerformancePoints}PP - ");

            if (i == 0)
            {
                sb.AppendLine($"${(int)(this.PrizePool * FirstPlaceMoneyPercentage)}");
            }
            else if (i == 1)
            {
                sb.AppendLine($"${(int)(this.PrizePool * SecondPlaceMoneyPercentage)}");
            }
            else
            {
                sb.AppendLine($"${(int)(this.PrizePool * ThirdPlaceMoneyPercentage)}");
            }
        }

        return sb.ToString().Trim();
    }
}