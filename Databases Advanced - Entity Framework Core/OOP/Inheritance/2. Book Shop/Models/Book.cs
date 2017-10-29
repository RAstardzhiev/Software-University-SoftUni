namespace _2.Book_Shop.Models
{
    using System;
    using System.Text;

    public class Book
    {
        private const string AuthorSecondNameStartsWithDigitExceptionMessage = "Author not valid!";
        private const string TitleTooShortExceptionMessage = "Title not valid!";
        private const string PriceNonZeroOrNegativeExceptionMessage = "Price not valid!";

        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get => this.title;

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(TitleTooShortExceptionMessage);
                }

                this.title = value;
            }
        }

        public string Author
        {
            get => this.author;

            private set
            {
                var lastIndexOfSpace = value.Trim().LastIndexOf(' ');
                if (lastIndexOfSpace > 0 && char.IsDigit(value.Substring(lastIndexOfSpace + 1, 1)[0]))
                {
                    throw new ArgumentException(AuthorSecondNameStartsWithDigitExceptionMessage);
                }

                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(PriceNonZeroOrNegativeExceptionMessage);
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
