namespace P03_SalesDatabase.Data.Models
{
    using System;

    public class Sale
    {
        public int SaleId { get; set; }

        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
