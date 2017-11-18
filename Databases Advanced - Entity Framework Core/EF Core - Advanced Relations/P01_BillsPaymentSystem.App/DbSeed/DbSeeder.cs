namespace P01_BillsPaymentSystem.App.DbSeed
{
    using System;
    using P01_BillsPaymentSystem.Data;
    using System.IO;
    using P01_BillsPaymentSystem.Data.Models;

    public class DbSeeder
    {
        private const string NamesFilePath = @"DbSeed\TestName.txt";

        private Random randomGenrrator;
        private string[] names;

        public DbSeeder()
            :this(new Random(), File.ReadAllText(NamesFilePath).Split())
        {
        }

        public DbSeeder(Random randomGenrrator, string[] names)
        {
            this.randomGenrrator = randomGenrrator;
            this.names = names;
        }

        public void Seed(BillsPaymentSystemContext context)
        {
            var users = this.CreateUSers(250);
            var creditCards = this.CreateCreditCards(250);
            var bankAccounts = this.CreateBankAccounts(250);
            this.SeedPaymentMethods(context, 250, users, creditCards, bankAccounts);
        }

        private void SeedPaymentMethods(BillsPaymentSystemContext context, int rows, User[] users, CreditCard[] creditCards, BankAccount[] bankAccounts)
        {
            var paymentMethods = new PaymentMethod[rows];

            for (int i = 0; i < paymentMethods.Length; i++)
            {
                var isBankAccount = randomGenrrator.Next() % 2 == 0;

                try
                {
                    paymentMethods[i] = isBankAccount
                        ? new PaymentMethod(users[randomGenrrator.Next(users.Length)], bankAccounts[i])
                        : new PaymentMethod(users[randomGenrrator.Next(users.Length)], creditCards[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            context.PaymentMethods.AddRange(paymentMethods);
            context.SaveChanges();
        }

        private BankAccount[] CreateBankAccounts(int rows)
        {
            var accounts = new BankAccount[rows];

            for (int i = 0; i < accounts.Length; i++)
            {
                var balance = randomGenrrator.Next(1000, 10000000);
                var bankName = $"{randomGenrrator.Next(30)} Name - Bank";
                var swift = $"{randomGenrrator.Next(10000000, 1000000000)}{randomGenrrator.Next(10000000, 1000000000)}";

                accounts[i] = new BankAccount(balance, bankName, swift);
            }

            return accounts;
        }

        private CreditCard[] CreateCreditCards(int rows)
        {
            var creditCards = new CreditCard[rows];

            for (int i = 0; i < creditCards.Length; i++)
            {
                var limit = randomGenrrator.Next(500, 1500);
                var moneyOwed = randomGenrrator.Next(limit);
                var expirationDate = DateTime.Now.AddMonths(randomGenrrator.Next(20));

                creditCards[i] = new CreditCard(limit, moneyOwed, expirationDate);
            }

            return creditCards;
        }

        private User[] CreateUSers(int rows)
        {
            var users = new User[rows];

            for (int i = 0; i < users.Length; i++)
            {
                var firstName = this.names[randomGenrrator.Next(this.names.Length)];
                var lastName = this.names[randomGenrrator.Next(this.names.Length)];
                var email = $"{firstName}_{lastName}{randomGenrrator.Next(100000)}@gmail.com";
                var password = $"{randomGenrrator.Next(100000000, 1000000000)}";

                users[i] = new User(firstName, lastName, email, password);
            }

            return users;
        }
    }
}
