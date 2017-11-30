namespace BusTickets.Models
{
    public class Ticket
    {
        private Ticket()
        {
        }

        public Ticket(decimal price, string seat, Customer customer, Trip trip)
        {
            this.Price = price;
            this.Seat = seat;
            this.Customer = customer;
            this.Trip = trip;
        }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Seat { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
