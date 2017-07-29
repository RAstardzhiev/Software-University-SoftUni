namespace _01.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private const int CurrentInternalIndexInitialValue = 0;

        private readonly List<T> data;
        private int currentInternalIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.currentInternalIndex = CurrentInternalIndexInitialValue;
        }

        public ListyIterator(IEnumerable<T> collectionData)
        {
            this.data = new List<T>(collectionData);
        }

        public bool Move()
        {
            if (this.currentInternalIndex < this.data.Count - 1)
            {
                this.currentInternalIndex++;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool HasNext() => this.currentInternalIndex < this.data.Count - 1;

        public T Print()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return this.data[this.currentInternalIndex];
        }

        public IEnumerator<T> GetEnumerator()
        {
            // return new ListyIteratorEnumerator(this.data); // Enumerator implementation

            // Simpler variation
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class ListyIteratorEnumerator : IEnumerator<T>
        {
            private readonly List<T> data;

            private int currentIndex;

            public ListyIteratorEnumerator(List<T> data)
            {
                this.Reset();
                this.data = data;
            }

            public T Current => this.data[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext() => ++this.currentIndex < this.data.Count;

            public void Reset() => this.currentIndex = -1;
        }
    }
}
