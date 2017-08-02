namespace _01.Stealer
{
    public class Hacker
    {
        // Test File INTENTIONALLY containing mistakes!!!
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {

        }
    }
}
