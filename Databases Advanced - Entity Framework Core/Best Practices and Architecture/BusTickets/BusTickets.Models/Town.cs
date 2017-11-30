namespace BusTickets.Models
{
    using System.Collections.Generic;

    public class Town
    {
        private Town()
        {
            this.Customers = new HashSet<Customer>();
            this.BusStations = new HashSet<BusStation>();
        }

        public Town(string name, Country country)
            :this()
        {
            this.Name = name;
            this.Country = country;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<BusStation> BusStations { get; set; }
    }
}