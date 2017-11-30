namespace BusTickets.App.Commands
{
    using System;
    using System.Linq;
    using System.Text;
    using BusTickets.App.Commands.Abstractions;
    using BusTickets.Data;

    public class PrintInfoCommand : Command
    {
        private const string StationNotFoundExceptionMessage = "Does not exist a Bus Station with an Id: ";

        public PrintInfoCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        // print-info {Bus Station ID}
        public override string Execute(BusTicketsContext context)
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(InvalidCommandArgsExceptionMessage);
            }

            var busStationId = int.Parse(this.CmdArgs[0]);
            var stationInfo = context.BusStations
                .Select(bs => new
                {
                    bs.Id,
                    StationName = bs.Name,
                    TownName = bs.Town.Name,
                    Arrivals = bs.ArrivingTrips
                        .Select(at => $"From {at.OriginBusStation.Name} | Arrive at: {at.ArrivalTime.ToString("hh:mm dd.MM.yyy")} | Status: {at.Status}"),
                    Departures = bs.StartingTrips
                        .Select(st => $"To {st.DestinationBusStation.Name} | Depart at: {st.DepartureTime.ToString("hh:mm dd.MM.yyy")} | Status {st.Status}")
                })
                .SingleOrDefault(s => s.Id == busStationId);

            if (stationInfo == null)
            {
                throw new ArgumentException(StationNotFoundExceptionMessage + busStationId);
            }

            var sb = new StringBuilder();
            sb.AppendLine($"{stationInfo.StationName}, {stationInfo.TownName}")
                .AppendLine("Arrivals:")
                .AppendLine(string.Join(Environment.NewLine, stationInfo.Arrivals))
                .AppendLine("Departures:")
                .AppendLine(string.Join(Environment.NewLine, stationInfo?.Departures));

            return sb.ToString();
        }
    }
}
