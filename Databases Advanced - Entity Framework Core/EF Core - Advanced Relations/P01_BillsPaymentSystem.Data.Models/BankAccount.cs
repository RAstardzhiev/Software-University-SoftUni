namespace P01_BillsPaymentSystem.Data.Models
{
    using System;

    public class BankAccount
    {
        private const string InsufficientFundsExceptionMessage = "Insufficient funds!!!";
        private const string NegativeWithdrawExceptionMessage = "Cannot withdraw Negative amount!!!";
        private const string NegativeDepositExceptionMessage = "Cannot deposit Negative amount!!!";

        private BankAccount()
        {
        }

        public BankAccount(decimal balance, string bankName, string swift)
        {
            this.Balance = balance;
            this.BankName = bankName;
            this.SWIFT = swift;
        }

        public int BankAccountId { get; set; }

        public decimal Balance { get; private set; }

        public string BankName { get; set; }

        public string SWIFT { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException(InsufficientFundsExceptionMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentException(NegativeWithdrawExceptionMessage);
            }

            this.Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(NegativeDepositExceptionMessage);
            }

            this.Balance += amount;
        }
    }
}
