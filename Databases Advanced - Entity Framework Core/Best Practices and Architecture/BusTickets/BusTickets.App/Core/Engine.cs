namespace BusTickets.App.Core
{
    using BusTickets.App.Interfaces;
    using BusTickets.Data;
    using BusTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using RandomDataGenerator;
    using System;

    public class Engine
    {
        private const int SeedCount = 100;

        private BusTicketsContext context;
        private ICommandDispatcher<ICommand> commandDispatcher;

        public Engine(BusTicketsContext context, ICommandDispatcher<ICommand> commandDispatcher)
        {
            this.context = context;
            this.commandDispatcher = commandDispatcher;
        }

        public void Run()
        {
            // this.ResetDatabase(context);

            while (true)
            {
                var input = Console.ReadLine().Split();
                var cmdResult = string.Empty;

                try
                {
                    var command = this.commandDispatcher.InstantiateCommand(input);
                    cmdResult = command.Execute(this.context);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.WriteLine(cmdResult);
            }
        }

        private void ResetDatabase(BusTicketsContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            SeedDb(context);
        }

        private void SeedDb(BusTicketsContext context)
        {
            var generator = new DataGenerator();

            var countries = GetCountries(generator, SeedCount);
            var busCompanies = GetBusCompanies(generator, countries, SeedCount);
            var towns = GetTowns(generator, countries, SeedCount);
            var busStations = GetStations(generator, towns, SeedCount);
            var customers = GetCustomers(generator, towns, SeedCount);
            var bankAccounts = GetBankAccounts(generator, customers, SeedCount);
            var trips = GetTrips(generator, busStations, busCompanies, SeedCount);
            var tickets = GetTickets(generator, customers, trips, SeedCount);
            var reviews = GetReviews(generator, busCompanies, customers, SeedCount / 2);

            context.Trips.AddRange(trips);
            context.Tickets.AddRange(tickets);
            context.Reviews.AddRange(reviews);
            context.BankAccounts.AddRange(bankAccounts);
            context.SaveChanges();
        }

        private Review[] GetReviews(DataGenerator generator, BusCompany[] busCompanies, Customer[] customers, int seedCount)
        {
            var reviews = new Review[SeedCount];

            for (int i = 0; i < reviews.Length; i++)
            {
                var content = generator.GenerateString(50, 150);
                var grade = generator.GenerateDouble(1 * DataGenerator.FloatDivisor, 10 * DataGenerator.FloatDivisor);
                var date = generator.GenerateDate();
                var company = generator.GetElementFromSequence(busCompanies);
                var customer = generator.GetElementFromSequence(customers);
                reviews[i] = new Review(content, grade, date, company, customer);
            }

            return reviews;
        }

        private Ticket[] GetTickets(DataGenerator generator, Customer[] customers, Trip[] trips, int seedCount)
        {
            var tickets = new Ticket[seedCount];

            for (int i = 0; i < tickets.Length; i++)
            {
                var price = generator.GenerateDecimal();
                var seetNumber = generator.GenerateNumberAndLettersString(1, 5);
                var customer = generator.GetElementFromSequence(customers);
                var trip = generator.GetElementFromSequence(trips);
                tickets[i] = new Ticket(price, seetNumber, customer, trip);
            }

            return tickets;
        }

        private Trip[] GetTrips(DataGenerator generator, BusStation[] busStations, BusCompany[] busCompanies, int seedCount)
        {
            var trips = new Trip[SeedCount];

            for (int i = 0; i < trips.Length; i++)
            {
                var depDate = generator.GenerateDate();
                var arrDate = generator.GenerateDate(depDate);
                var originStation = generator.GetElementFromSequence(busStations);
                var destinationStation = generator.GetElementFromSequence(busStations);
                var company = generator.GetElementFromSequence(busCompanies);
                trips[i] = new Trip(depDate, arrDate, originStation, destinationStation, company);
            }

            return trips;
        }

        private BankAccount[] GetBankAccounts(DataGenerator generator, Customer[] customers, int seedCount)
        {
            var accounts = new BankAccount[SeedCount];

            for (int i = 0; i < accounts.Length; i++)
            {
                var accNumber = generator.GenerateNumberAndLettersString(26, 30);
                var balance = generator.GenerateDecimal();
                var customer = generator.GetElementFromSequence(customers);
                accounts[i] = new BankAccount(accNumber, balance, customer);
            }

            return accounts;
        }

        private Customer[] GetCustomers(DataGenerator generator, Town[] towns, int seedCount)
        {
            var customers = new Customer[SeedCount];

            for (int i = 0; i < customers.Length; i++)
            {
                var firstName = generator.GenerateString();
                var lastName = generator.GenerateString();
                var town = generator.GetElementFromSequence(towns);
                customers[i] = new Customer(firstName, lastName, town);
            }

            return customers;
        }

        private BusStation[] GetStations(DataGenerator generator, Town[] towns, int seedCount)
        {
            var stations = new BusStation[SeedCount];

            for (int i = 0; i < stations.Length; i++)
            {
                var name = generator.GenerateString();
                var town = generator.GetElementFromSequence(towns);
                stations[i] = new BusStation(name, town);
            }

            return stations;
        }

        private Town[] GetTowns(DataGenerator generator, Country[] countries, int seedCount)
        {
            var towns = new Town[SeedCount];

            for (int i = 0; i < towns.Length; i++)
            {
                var name = generator.GenerateString();
                var country = generator.GetElementFromSequence(countries);
                towns[i] = new Town(name, country);
            }

            return towns;
        }

        private BusCompany[] GetBusCompanies(DataGenerator generator, Country[] countries, int seedCount)
        {
            var busCompanies = new BusCompany[seedCount];

            for (int i = 0; i < busCompanies.Length; i++)
            {
                var name = generator.GenerateString();
                var country = generator.GetElementFromSequence(countries);
                busCompanies[i] = new BusCompany(name, country);
            }

            return busCompanies;
        }

        private Country[] GetCountries(DataGenerator generator, int seedCount)
        {
            var countries = new Country[seedCount];

            for (int i = 0; i < countries.Length; i++)
            {
                var countryName = generator.GenerateString();
                countries[i] = new Country(countryName);
            }

            return countries;
        }
    }
}
