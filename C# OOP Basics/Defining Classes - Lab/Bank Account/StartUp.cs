namespace Bank_Account
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split();

                switch (command[0])
                {
                    case "Create":
                        CreateAccount(int.Parse(command[1]), accounts);
                        break;
                    case "Deposit":
                        Deposit(int.Parse(command[1]), double.Parse(command[2]), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(int.Parse(command[1]), double.Parse(command[2]), accounts);
                        break;
                    case "Print":
                        Print(int.Parse(command[1]), accounts);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(accounts[id].ToString());
        }

        private static void Withdraw(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            accounts[id].Withdraw(amount);
        }

        private static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accounts[id].Deposit(amount);
        }

        private static void CreateAccount(int id, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                return;
            }

            accounts[id] = new BankAccount(id);
        }
    }
}
