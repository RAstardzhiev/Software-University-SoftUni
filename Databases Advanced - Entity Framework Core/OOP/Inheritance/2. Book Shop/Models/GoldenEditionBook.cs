using System.Text;

namespace _2.Book_Shop.Models
{
    public class GoldenEditionBook : Book
    {
        private const decimal PriceMultiplyer = 1.3M;

        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get => base.Price;

            protected set
            {
                 base.Price = value * PriceMultiplyer;
            }
        }
    }
}
