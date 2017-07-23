namespace _08.Custom_List.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class MyList<T> : IMyList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private const int Initialcapacity = 16;

        private T[] data;
        private int length;

        public MyList()
        {
            this.data = new T[Initialcapacity];
        }

        public void Add(T element)
        {
            if (this.length == this.data.Length)
            {
                this.data = this.data.Concat(new T[this.length]).ToArray();
            }

            this.data[this.length] = element;
            this.length++;
        }

        public bool Contains(T element)
        {
            if (this.length == 0)
            {
                return false;
            }

            var comparer = EqualityComparer<T>.Default;

            foreach (var item in this.data)
            {
                // if (item.Equals(element)) // Input: Contains null -> NullReferenceException
                if (comparer.Equals(item, element)) // This has a check for null
                {
                    return true;
                }
            }

            return false;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            for (int i = 0; i < this.length; i++)
            {
                if (this.data[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            if (this.length == 0)
            {
                throw new ArgumentException("The collection is EMPTY!!!");
            }

            var max = this.data[0];

            for (int i = 0; i < this.length; i++)
            {
                if (this.data[i].CompareTo(max) > 0)
                {
                    max = this.data[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (this.length == 0)
            {
                throw new ArgumentException("The collection is EMPTY!!!");
            }

            var min = this.data[0];

            for (int i = 0; i < this.length; i++)
            {
                if (this.data[i].CompareTo(min) < 0)
                {
                    min = this.data[i];
                }
            }

            return min;
        }

        public T Remove(int index)
        {
            if (index >= this.length || index < 0 || this.length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var element = this.data[index];
            this.data = this.data.Take(index).Concat(this.data.Skip(index + 1)).ToArray();
            this.length--;
            return element;
        }

        public void Sort()
        {
            this.data = this.data
                .Take(this.length)
                .OrderBy(x => x)
                .Concat(new T[this.data.Length - this.length])
                .ToArray();
        }

        public void Swap(int index1, int index2)
        {
            if (this.length == 0 || index1 >= this.length || index2 >= this.length || index1 < 0 || index2 < 0)
            {
                return;
            }

            var temp = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.Take(this.length).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.data.Take(this.length).GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.data.Take(this.length));
        }
    }
}
