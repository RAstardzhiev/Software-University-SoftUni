namespace _02.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }

        protected override decimal Price
        {
            set
            {
                base.Price = value * 1.3M;
            }
        }
    }
}
