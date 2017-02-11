namespace Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Book_Library_Modification
    {
        public static void Main(string[] args)
        {
            Library library = FillLibrary();
            PrintAuthorsAfterGivenDate(library);
        }

        private static void PrintAuthorsAfterGivenDate(Library library)
        {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();
            foreach (Book book in library.Books)
            {
                result[book.Title] = book.ReleaseDate;
            }

            PrintTheResult(result);
        }

        private static void PrintTheResult(Dictionary<string, DateTime> result)
        {
            DateTime initialDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            result = result
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .Where(x => x.Value > initialDate)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine(string.Join("\n", result.Select(x => x.Key + " -> " + x.Value.ToString("dd.MM.yyyy"))));
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
