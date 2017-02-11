namespace Book_Library
{
    using System;

    public class Book
    {
        public string Title, Authir, Publisher, ISBN;
        public DateTime ReleaseDate;
        public double Price;

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, double price)
        {
            this.Title = title;
            this.Authir = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }
}
