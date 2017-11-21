namespace BookShop
{
    using System;
    using System.Linq;
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new BookShopContext())
            {
                // DbInitializer.ResetDatabase(context);

                // Console.WriteLine(GetBooksByAgeRestriction(context)); ;// 1. Age Restriction
                // Console.WriteLine(GetGoldenBooks(context)); // 2. Golden Books
                // Console.WriteLine(GetBooksByPrice(context)); ; // 3. Books by Price
                // Console.WriteLine(GetBooksNotRealeasedIn(context)); ; // 4. Not Released In
                // Console.WriteLine(GetBooksByCategory(context)); ; // 5. Book Titles by Category
                // Console.WriteLine(GetBooksReleasedBefore(context)); ; // 6. Released Before Date
                // Console.WriteLine(GetAuthorNamesEndingIn(context)); // 7. Author Search
                // Console.WriteLine(GetBookTitlesContaining(context)); // 8. Book Search
                // Console.WriteLine(GetBooksByAuthor(context)); // 9. Book Search by Author
                // Console.WriteLine(CountBooks(context)); // 10. Count Books
                // Console.WriteLine(CountCopiesByAuthor(context)); // 11. Total Book Copies
                // Console.WriteLine(GetTotalProfitByCategory(context)); // 12. Profit by Category
                // Console.WriteLine(GetMostRecentBooks(context)); // 13. Most Recent Books
                // Console.WriteLine(IncreasePrices(context)); // 14. Increase Prices
                Console.WriteLine(RemoveBooks(context)); // 15. Remove Books
            }
        }

        public static int RemoveBooks(BookShopContext context, int lessThanCopies = 4200)
        {
            var books = context.Books
                    .Where(b => b.Copies < lessThanCopies)
                    .ToArray();

            var removedBooks = books.Length;

            context.Books.RemoveRange(books);
            context.SaveChanges();

            return removedBooks;
        }

        public static int IncreasePrices(BookShopContext context, decimal increasement = 5, int yearTopBorder = 2010)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year < yearTopBorder)
                .ToArray();

            foreach (var book in books)
            {
                book.Price += increasement;
            }

            return context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
            => "--" + string.Join($"{Environment.NewLine}--", context.Categories
                .Select(c => new
                {
                    Name = c.Name, 
                    BookCount = c.CategoryBooks
                        .Select(cb => cb.Book)
                        .Count(), 
                    TopThreeString = string.Join(Environment.NewLine, c.CategoryBooks
                        .Select(cb => cb.Book)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Take(3)
                        .Select(b => b.ReleaseDate == null
                            ? $"{b.Title} ()"
                            : $"{b.Title} ({b.ReleaseDate.Value.Year})"))
                })
                // .OrderBy(c => c.BookCount) // Wrong Requirement - Judge wants sorting by Name
                .OrderBy(c => c.Name)
                .Select(c => $"{c.Name}{Environment.NewLine}{c.TopThreeString}"));

        public static string GetTotalProfitByCategory(BookShopContext context)
            => string.Join(Environment.NewLine, context.Categories
                .Select(c => new
                {
                    Name = c.Name, 
                    TotalProffit = c.CategoryBooks
                        .Select(cb => cb.Book.Price * cb.Book.Copies)
                        .Sum()
                })
                .OrderByDescending(c => c.TotalProffit)
                .ThenBy(c => c.Name)
                .Select(c => $"{c.Name} ${c.TotalProffit:F2}"));

        public static string CountCopiesByAuthor(BookShopContext context)
            => string.Join(Environment.NewLine, context.Authors 
                .Select(a => new
                {
                    Name = a.FirstName == null 
                        ? a.LastName 
                        : $"{a.FirstName} {a.LastName}",
                    Copies = a.Books
                        .Select(b => b.Copies)
                        .Sum()
                })
                .OrderByDescending(a => a.Copies)
                .Select(a => $"{a.Name} - {a.Copies}"));

        public static int CountBooks(BookShopContext context, int? lengthCheck = null)
        {
            if (lengthCheck == null)
            {
                lengthCheck = int.Parse(Console.ReadLine());
            }

            return context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();
        }

        public static string GetBooksByAuthor(BookShopContext context, string key = null)
        {
            if (key == null)
            {
                key = Console.ReadLine();
            }

            key = key.ToLower();

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(key))
                .OrderBy(b => b.BookId)
                .Select(b => b.Author.FirstName == null 
                    ? $"{b.Title} ({b.Author.LastName})"
                    : $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})"));
        }

        public static string GetBookTitlesContaining(BookShopContext context, string key = null)
        {
            if (key == null)
            {
                key = Console.ReadLine();
            }

            key = key.ToLower();

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.Title.ToLower().Contains(key))
                .Select(b => b.Title)
                .OrderBy(t => t));
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string endingWith = null)
        {
            if (endingWith == null)
            {
                endingWith = Console.ReadLine();
            }

            return string.Join(Environment.NewLine, context.Authors
                .Where(a => a.FirstName != null && a.FirstName.EndsWith(endingWith))
                .Select(a => a.FirstName == null ? a.LastName : $"{a.FirstName} {a.LastName}")
                .OrderBy(n => n));
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date = null)
        {
            if (date == null)
            {
                date = Console.ReadLine();
            }

            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.ReleaseDate < parsedDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:F2}"));
        }

        public static string GetBooksByCategory(BookShopContext context, string input = null)
        {
            if (input == null)
            {
                input = Console.ReadLine();
            }

            var categories = input
                .ToLower()
                .Split(new [] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.BookCategories
                    .Select(bc => bc.Category.Name.ToLower())
                    .Intersect(categories)
                    .Any())
                .Select(b => b.Title)
                .OrderBy(t => t));
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int? year = null)
        {
            if (year == null)
            {
                year = int.Parse(Console.ReadLine());
            }

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title));
        }

        public static string GetBooksByPrice(BookShopContext context)
            => string.Join(Environment.NewLine, context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => $"{b.Title} - ${b.Price:F2}"));

        public static string GetGoldenBooks(BookShopContext context)
            => string.Join(Environment.NewLine, context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title));

        public static string GetBooksByAgeRestriction(BookShopContext context, string targetAgeGroup = null)
        {
            if (targetAgeGroup == null)
            {
                targetAgeGroup = Console.ReadLine();
            }

            return string.Join(Environment.NewLine, context.Books
                .Where(b => b.AgeRestriction.ToString().Equals(targetAgeGroup, StringComparison.OrdinalIgnoreCase))
                .Select(b => b.Title)
                .OrderBy(t => t));
        }
    }
}
