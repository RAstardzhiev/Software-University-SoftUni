namespace _01.Library.Models
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            var titleDiff = x.Title.CompareTo(y.Title);

            if (titleDiff != 0)
            {
                return titleDiff;
            }

            return y.Year.CompareTo(x.Year);
        }
    }
}
