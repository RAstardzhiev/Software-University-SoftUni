namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using PhotoShare.Client.Interfaces;
    using PhotoShare.Services.Interfaces;

    public class AddTownCommand : ICommand
    {
        private const string ExistingTownExceptionMesage = "Town {0} was already added!";

        private const string SuccessfulAddedTown = "Town {0} was added successfully!";
        private const string SuccessfulAddedTownToCountry = "Successfully added Town {0} to Country {1}!";

        private PhotoShareContext context;
        private IUserSessionService userSession;

        public AddTownCommand(PhotoShareContext context, IUserSessionService userSession) 
        {
            this.context = context;
            this.userSession = userSession;
        }

        // AddTown <townName> <countryName>
        public string Execute(string[] data)
        {
            this.userSession.Authorize();
            string townName = data[0];
            string country = data[1];

            var town = this.context.Towns
                .SingleOrDefault(t => t.Name.Equals(townName, StringComparison.OrdinalIgnoreCase));

            if (town != null)
            {
                if (town.Country == null)
                {
                    town.Country = country;
                    this.context.SaveChanges();
                    return string.Format(SuccessfulAddedTownToCountry, town.Name, town.Country);
                }
                else
                {
                    throw new ArgumentException(string.Format(ExistingTownExceptionMesage, townName));
                }
            }

            town = new Town(townName);
            town.Country = country;

            this.context.Towns.Add(town);
            this.context.SaveChanges();

            return string.Format(SuccessfulAddedTown, townName);
        }
    }
}
