namespace P01_BillsPaymentSystem.Data.Models
{
    using System;

    public class CreditCard
    {
        private const string NegativeWithdrawExceptionMessage = "Cannot withdraw Negative amount!!!";
        private const string InsufficientLimitExceptionMessage = "Insufficient limit! Please contact us for a new contract which will be more suitable for for you. :)";
        private const string NegativeDepositExceptionMessage = "Cannot deposit Negative amount!!!";
        private const string DepositTooMuchExceptionMessage = "The deposit is bigger than the owed sum ({0:C2})!!!";

        private CreditCard()
        {
        }

        public CreditCard(decimal limit, decimal moneyOwed, DateTime expirationDate)
        {
            this.Limit = limit;
            this.MoneyOwed = moneyOwed;
            this.ExpirationDate = expirationDate;
        }

        public int CreditCardId { get; set; }

        public decimal Limit { get; private set; }

        public decimal MoneyOwed { get; private set; }

        public decimal LimitLeft => this.Limit - this.MoneyOwed;

        public DateTime ExpirationDate { get; set; }

        public PaymentMethod PaymentMethod { get; private set; }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(NegativeWithdrawExceptionMessage);
            }

            if (this.LimitLeft < amount)
            {
                throw new ArgumentException(InsufficientLimitExceptionMessage);
            }

            this.MoneyOwed += amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(NegativeDepositExceptionMessage);
            }

            if (this.MoneyOwed < amount)
            {
                throw new ArgumentException(string.Format(DepositTooMuchExceptionMessage, this.MoneyOwed));
            }

            this.MoneyOwed -= amount;
        }
    }
}
