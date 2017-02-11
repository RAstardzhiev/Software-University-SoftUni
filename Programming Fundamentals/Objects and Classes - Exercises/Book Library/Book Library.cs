namespace Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Book_Library
    {
        public static void Main(string[] args)
        {
            Library gatheredBooks = FillLibrary();
            PrintPricesByAuthor(gatheredBooks);
        }

        private static void PrintPricesByAuthor(Library gatheredBooks)
        {
            Dictionary<string, double> moneyByAuthors = new Dictionary<string, double>();
            foreach (Book book in gatheredBooks.Books)
            {
                if (moneyByAuthors.ContainsKey(book.Authir))
                {
                    moneyByAuthors[book.Authir] += book.Price;
                }
                else
                {
                    moneyByAuthors[book.Authir] = book.Price;
                }
            }

            moneyByAuthors = moneyByAuthors
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, double> author in moneyByAuthors)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }

        private static Library FillLibrary()
        {
            Library gatherBooks = new Library() { Name = "gatheredBooks", Books = new List<Book>() };
            int numberOfBooks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookData = Console.ReadLine().Split(' ');

                // {title} {author} {publisher} {release date} {ISBN} {price}
                Book temp = new Book(bookData[0], bookData[1], bookData[2], DateTime.ParseExact(bookData[3], "d.M.yyyy", CultureInfo.InvariantCulture), bookData[4], double.Parse(bookData[5]));
                gatherBooks.Books.Add(temp);
            }

            return gatherBooks;
        }
    }
}
