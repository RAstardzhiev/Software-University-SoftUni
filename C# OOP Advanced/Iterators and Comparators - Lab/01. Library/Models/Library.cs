namespace _01.Library.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        private readonly SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);

            //for (int i = 0; i < this.books.Count; i++)
            //{
            //    yield return this.books[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly IList<Book> data;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> data)
            {
                this.data = new List<Book>(data);
                this.Reset();
            }

            public Book Current => this.data[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext() => ++this.currentIndex < this.data.Count;

            public void Reset() => this.currentIndex = -1;
        }
    }
}
