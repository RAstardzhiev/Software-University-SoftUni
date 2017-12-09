using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Stations.Data;
using Stations.DataProcessor.Dto.Export;
using Stations.Models.Enums;

namespace Stations.DataProcessor
{
	public class Serializer
	{
		public static string ExportDelayedTrains(StationsDbContext context, string dateAsString)
		{
            var date = DateTime.ParseExact(dateAsString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var trains = context.Trains
                .Where(t => t.Trips.
                    Any(trip => trip.Status == TripStatus.Delayed && trip.DepartureTime <= date))
                .Select(t => new
                {
                    t.TrainNumber,
                    DelayedTrips = t.Trips
                        .Where(trip => trip.Status == TripStatus.Delayed && trip.DepartureTime <= date)
                        .ToArray()
                })
                .Select(t => new
                {
                    t.TrainNumber,
                    DelayedTimes = t.DelayedTrips.Length,
                    MaxDelayedTime = t.DelayedTrips
                        .Max(trip => trip.TimeDifference)
                        .ToString()
                })
                .OrderByDescending(t => t.DelayedTimes)
                .ThenByDescending(t => t.MaxDelayedTime)
                .ThenBy(t => t.TrainNumber);

            var jsonString = JsonConvert.SerializeObject(trains, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
		}

		public static string ExportCardsTicket(StationsDbContext context, string cardType)
		{
            var parsedCardType = Enum.Parse<CardType>(cardType);

            var cards = context.Cards
                .Where(c => c.Type == parsedCardType && c.BoughtTickets.Any())
                .Select(c => new CardExportDto
                {
                    Name = c.Name,
                    Type = cardType.ToString(),
                    Tickets = c.BoughtTickets
                        .Select(t => new TicketExportDto
                        {
                            OriginStation = t.Trip.OriginStation.Name,
                            DestinationStation = t.Trip.DestinationStation.Name,
                            DepartureTime = t.Trip.DepartureTime
                                .ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture)
                        })
                        .ToArray()
                })
                .OrderBy(c => c.Name)
                .ToArray();

            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(CardExportDto[]), new XmlRootAttribute("Cards"));
            serializer.Serialize(new StringWriter(sb), cards, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString();
            return result;
        }
	}
}