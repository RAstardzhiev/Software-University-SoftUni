namespace BusTickets.Models
{
    using System.Collections.Generic;

    public class Country
    {
        private Country()
        {
            this.BusCompanies = new HashSet<BusCompany>();
            this.Towns = new HashSet<Town>();
        }

        public Country(string name)
            :this()
        {
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BusCompany> BusCompanies { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}
