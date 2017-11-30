namespace BusTickets.App.Commands
{
    using System;
    using System.Linq;
    using BusTickets.App.Commands.Abstractions;
    using BusTickets.Data;

    public class PrintReviewsCommand : Command
    {
        private const string CompanyNotFoundExceptionMessage = "Cannot found Company with an Id: ";

        public PrintReviewsCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        // print-reviews {Bus Company ID}
        public override string Execute(BusTicketsContext context)
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(InvalidCommandArgsExceptionMessage);
            }

            var companyId = int.Parse(this.CmdArgs[0]);
            var company = context.BusCompanies
                .Select(c => new
                {
                    c.Id,
                    Reviews = c.Reviews
                        .Select(r => string.Concat($"{r.Id} {r.Grade} {r.PublishDate.ToString("hh:mm dd-MM-yyyy")}{Environment.NewLine}",
                            $"{r.Customer.FirstName} {r.Customer.LastName}{Environment.NewLine}",
                            r.Content))
                })
                .SingleOrDefault(c => c.Id == companyId);

            if (company == null)
            {
                throw new ArgumentException(string.Format(CompanyNotFoundExceptionMessage, companyId));
            }

            return company.Reviews == null
                ? "There is not reviews for this company"
                : "   - " + string.Join($"{Environment.NewLine}   - ", company.Reviews);
        }
    }
}
