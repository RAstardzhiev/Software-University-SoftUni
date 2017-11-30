namespace BusTickets.Models
{
    using System.Collections.Generic;

    public class BusStation
    {
        private BusStation()
        {
            this.StartingTrips = new HashSet<Trip>();
            this.ArrivingTrips = new HashSet<Trip>();
        }

        public BusStation(string name, Town town)
            :this()
        {
            this.Town = town;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Trip> StartingTrips { get; set; }

        public ICollection<Trip> ArrivingTrips { get; set; }
    }
}