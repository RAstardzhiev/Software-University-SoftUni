namespace BusTickets.App.Commands
{
    using System;
    using BusTickets.App.Commands.Abstractions;
    using BusTickets.Data;
    using System.Linq;
    using BusTickets.Models;

    public class BuyTicketCommand : Command
    {
        private const string EntityNotFoundExceptionMessage = "{0} with Id {1} not found!";

        public BuyTicketCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        // buy-ticket {customer ID} {Trip ID} {Price} {Seat}
        public override string Execute(BusTicketsContext context)
        {
            if (this.CmdArgs.Length != 4)
            {
                throw new ArgumentException(InvalidCommandArgsExceptionMessage);
            }

            var customerId = int.Parse(this.CmdArgs[0]);
            var tripId = int.Parse(this.CmdArgs[1]);
            var price = decimal.Parse(this.CmdArgs[2]);
            var seat = this.CmdArgs[3];

            var ticket = this.CreateTicket(context, customerId, tripId, price, seat);

            var customerFullName = $"{ticket.Customer.FirstName} {ticket.Customer.LastName}";
            return $"Customer {customerFullName} bought ticket for trip {ticket.Trip.Id} for {ticket.Price} on seat {ticket.Seat}";
        }

        private Ticket CreateTicket(BusTicketsContext context, int customerId, int tripId, decimal price, string seat)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                throw new ArgumentException(string.Format(EntityNotFoundExceptionMessage, nameof(Customer), customerId));
            }

            var trip = context.Trips.SingleOrDefault(t => t.Id == tripId);
            if (trip == null)
            {
                throw new ArgumentException(string.Format(EntityNotFoundExceptionMessage, nameof(Trip), tripId));
            }

            return new Ticket(price, seat, customer, trip);
        }
    }
}
