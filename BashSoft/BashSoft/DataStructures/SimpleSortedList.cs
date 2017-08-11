namespace BashSoft.DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public class SimpleSortedList<T> : ISimpleOrderedBag<T>
        where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] innearCollection;
        private int size;
        private IComparer<T> comparison;

        public SimpleSortedList(int capacity, IComparer<T> comparison)
        {
            this.comparison = comparison;
            this.InitializeInnearcollection(capacity);
        }

        public SimpleSortedList(IComparer<T> comparison)
            : this(DefaultSize, comparison)
        {
        }

        public SimpleSortedList(int capacity)
            : this(capacity, Comparer<T>.Create((x, y) => x.CompareTo(y)))
        {
        }

        public SimpleSortedList()
            : this(DefaultSize)
        {
        }

        public int Size => this.size;

        public void Add(T element)
        {
            if (this.innearCollection.Length == this.Size)
            {
                this.Resize();
            }

            this.innearCollection[this.Size] = element;
            this.size++;
            Array.Sort(this.innearCollection, 0, this.Size, this.comparison);
        }

        public void AddAll(ICollection<T> collection)
        {
            if (this.Size + collection.Count >= this.innearCollection.Length)
            {
                this.Multiresize(collection);
            }

            foreach (var element in collection)
            {
                this.innearCollection[this.Size] = element;
                this.size++;
            }

            Array.Sort(this.innearCollection, 0, this.Size, this.comparison);
        }

        public string JoinWith(string joiner)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var element in this)
            {
                builder.Append(element)
                    .Append(joiner);
            }

            if (builder.Length > 0)
            {
                builder.Remove(builder.Length - joiner.Length, joiner.Length);
            }

            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Size; i++)
            {
                yield return this.innearCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private void Resize()
        {
            T[] newCollection = new T[this.Size * 2];
            Array.Copy(this.innearCollection, newCollection, this.Size);
        }

        private void Multiresize(ICollection<T> collection)
        {
            int newSize = this.innearCollection.Length * 2;
            while (this.Size + collection.Count >= newSize)
            {
                newSize *= 2;
            }

            T[] newCollection = new T[newSize];
            Array.Copy(this.innearCollection, newCollection, this.Size);
            this.innearCollection = newCollection;
        }

        private void InitializeInnearcollection(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative!");
            }

            this.innearCollection = new T[capacity];
        }
    }
}
