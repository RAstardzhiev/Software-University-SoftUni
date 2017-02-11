namespace Sales_Report
{
    public class Sale
    {
        public string Town = string.Empty;
        public decimal Money = 0.0M;

        public Sale(string town, decimal money)
        {
            this.Town = town;
            this.Money = money;
        }
    }
}
