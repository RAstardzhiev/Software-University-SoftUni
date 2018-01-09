namespace Lists
{
    using System;

    public class ArrayList<T>
    {
        private const int DefaultCapacity = 2;

        private T[] data;

        public ArrayList()
        {
            this.data = new T[DefaultCapacity];
        }

        public ArrayList(T[] data)
        {
            this.data = data;
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.data[index];
            }

            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.data[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }

            this.data[Count++] = item;
        }

        public T RemoveAt(int index)
        {
            if (this.Count < this.data.Length / 4)
            {
                this.Resize();
            }

            var removedElement = this[index];

            this.Count--;

            for (int i = index; i < this.Count; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            return removedElement;
        }

        private void Resize()
        {
            Array.Resize(ref this.data, this.Count * 2);
        }
    }
}
