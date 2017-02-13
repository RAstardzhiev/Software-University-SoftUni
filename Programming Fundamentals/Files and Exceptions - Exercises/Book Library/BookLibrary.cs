namespace Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main(string[] args)
        {
            Library library = CreateLibrary();
            AuthorAndSumOfPrices(library);
            TitlesAfterDate(library);
        }

        public static void TitlesAfterDate(Library library)
        {
            // print all titles released after given date ordered by date and then by title lexicographically
            Dictionary<string, DateTime> result = TitleDate(library)
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllLines("../../InputOutput/Titles after given date.txt", result.Select(x => $"{x.Key} -> {x.Value:dd.MM.yyyy}"));
        }

        public static Dictionary<string, DateTime> TitleDate(Library library)
        {
            // day.month.year
            DateTime initialDate = DateTime.ParseExact(File.ReadAllText("../../InputOutput/Date.txt"), "d.M.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            foreach (Book book in library.Books)
            {
                if (initialDate < book.ReleaseDate)
                {
                    result[book.Title] = book.ReleaseDate;
                }
            }

            return result;
        }

        private static void AuthorAndSumOfPrices(Library library)
        {
            Dictionary<string, double> authorByPrices = PricesByAuthor(library.Books);
            File.WriteAllLines("../../InputOutput/Authors by Prices.txt", authorByPrices.Select(x => $"{x.Key} -> {x.Value:F2}"));
        }

        private static Dictionary<string, double> PricesByAuthor(List<Book> books)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            for (int i = 0; i < books.Count; i++)
            {
                if (!result.ContainsKey(books[i].Author))
                {
                    result[books[i].Author] = 0;
                }

                result[books[i].Author] += books[i].Price;
            }

            // ordered descending by price and then by author’s name lexicographically
            result = result
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            return result;
        }

        private static Library CreateLibrary()
        {
            Library library = new Library { Name = "The Penguins", Books = new List<Book>() };
            string[] booksData = File.ReadAllLines("../../InputOutput/Books Data.txt");

            for (int i = 0; i < booksData.Length; i++)
            {
                library.Books.Add(BuildBook(booksData[i]));
            }

            return library;
        }

        private static Book BuildBook(string bookDetails)
        {
            string[] data = bookDetails.Split(' ');

            // {title} {author} {publisher} {release date} {ISBN} {price}.
            // LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00
            Book book = new Book
            {
                Title = data[0],
                Author = data[1],
                Publisher = data[2],
                ReleaseDate = DateTime.ParseExact(data[3], "d.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN_Number = data[4],
                Price = double.Parse(data[5])
            };

            return book;
        }
    }
}
