namespace _1.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private const int Capacity = 16;

        private int[] data;
        private int count;

        public Database()
        {
            this.data = new int[Capacity];
        }

        public Database(params int[] numbers)
            : this()
        {
            if (numbers != null)
            {
                foreach (var item in numbers)
                {
                    this.Add(item);
                }
            }
        }

        public Database(IEnumerable<int> numbers)
            : this()
        {
            foreach (var item in numbers)
            {
                this.Add(item);
            }
        }

        public int Count => this.count;

        public void Add(int element)
        {
            if (this.count == this.data.Length)
            {
                throw new InvalidOperationException();
            }

            data[this.count] = element;
            this.count++;
        }

        public void Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            this.count--;
        }

        public int[] Fetch() => this.data.Take(this.count).ToArray();
    }
}
