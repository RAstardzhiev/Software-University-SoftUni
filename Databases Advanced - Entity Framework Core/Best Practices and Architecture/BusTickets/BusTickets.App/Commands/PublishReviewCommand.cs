namespace BusTickets.App.Commands
{
    using System;
    using BusTickets.App.Commands.Abstractions;
    using BusTickets.Data;
    using BusTickets.Models;
    using System.Linq;

    class PublishReviewCommand : Command
    {
        private const string EntityNotFoundExceptionMessage = "Customer with Id {0} not found!";
        private const string CompanyNotFoundExceptionMessage = "Company with name {0} not found!";

        public PublishReviewCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        // publish-review {Customer ID} {Grade} {Bus Company Name} {Content}
        public override string Execute(BusTicketsContext context)
        {
            if (this.CmdArgs.Length < 4)
            {
                throw new ArgumentException(InvalidCommandArgsExceptionMessage);
            }

            var customerId = int.Parse(this.CmdArgs[0]);
            var grade = double.Parse(this.CmdArgs[1]);
            var companyName = this.CmdArgs[2];
            var content = string.Join(" ", this.CmdArgs.Skip(3));

            var review = this.CreateReview(context, customerId, grade, companyName, content);

            var customerFullName = $"{review.Customer.FirstName} {review.Customer.LastName}";
            return $"Customer {customerFullName} published review for company {review.BusCompany.Name}";
        }

        private Review CreateReview(BusTicketsContext context, int customerId, double grade, string companyName, string content)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                throw new ArgumentException(string.Format(EntityNotFoundExceptionMessage, customerId));
            }

            var company = context.BusCompanies.SingleOrDefault(c => c.Name.Equals(companyName, StringComparison.OrdinalIgnoreCase));
            if (company == null)
            {
                throw new ArgumentException(string.Format(CompanyNotFoundExceptionMessage, companyName));
            }

            return new Review(content, grade, DateTime.Now, company, customer);
        }
    }
}
