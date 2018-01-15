namespace Circular_Queue
{
    using System;

    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] data;
        private int headIndex;
        private int tailIndex;

        public int Count { get; private set; }

        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.data = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            else if (this.tailIndex == this.data.Length)
            {
                if (this.headIndex > 0)
                {
                    this.tailIndex = 0;
                }
                else
                {
                    this.Resize();
                }
            }
            else if (this.Count > 0 && this.tailIndex == this.headIndex)
            {
                this.Resize();
            }

            this.data[this.tailIndex] = element;
            this.tailIndex++;
            this.Count++;
        }

        private void Resize()
        {
            var newData = new T[this.Count * 2];
            var currentIndex = this.headIndex;

            for (int i = 0; i < this.Count; i++)
            {
                if (currentIndex >= this.Count)
                {
                    currentIndex = 0;
                }

                newData[i] = this.data[currentIndex++];
            }

            this.data = newData;
            this.headIndex = 0;
            this.tailIndex = this.Count;
        }

        private void CopyAllElements(T[] newArray)
        {
            var currentiIndex = this.headIndex - 1;
            for (int i = 0; i < this.Count; i++)
            {
                currentiIndex++;
                if (currentiIndex >= this.data.Length)
                {
                    currentiIndex = 0;
                }

                newArray[i] = data[currentiIndex];
            }
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedItem = this.data[this.headIndex];
            this.headIndex++;
            if (this.headIndex >= this.data.Length)
            {
                this.headIndex = 0;
            }

            this.Count--;
            return removedItem;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            this.CopyAllElements(array);

            return array;
        }
    }
}
