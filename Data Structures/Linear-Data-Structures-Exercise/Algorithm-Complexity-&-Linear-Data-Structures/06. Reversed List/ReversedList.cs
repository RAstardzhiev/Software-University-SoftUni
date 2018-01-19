namespace _06.Reversed_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;

        private T[] data;

        public ReversedList(int capacity = InitialCapacity)
        {
            this.data = new T[capacity];
        }

        public int Count { get; private set; }

        public int Capacity => this.data.Length;

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[this.Count - index - 1];
            }

            set
            {
                this.ValidateIndex(index);
                this.data[this.Count - index - 1] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }

            this.data[Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);
            var removedItem = this.data[this.Count - index - 1];

            for (int i = this.Count - index; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }

            this.Count--;
            return removedItem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private void Resize()
        {
            Array.Resize(ref this.data, this.Count * 2);
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}