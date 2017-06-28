namespace Bank_Account
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount() : this(0, 0) { }

        public BankAccount(int id) : this(id, 0.0) { }

        public BankAccount(double balance) : this(0, balance) { }

        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:F2}";
        }
    }
}
