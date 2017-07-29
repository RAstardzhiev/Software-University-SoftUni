namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;

        private T[] data;
        private int length;

        public Stack()
        {
            this.data = new T[InitialCapacity];
        }

        public T Pop()
        {
            if (this.length == 0)
            {
                throw new ArgumentException("No elements");
            }

            this.length--;
            var lastElement = this.data[this.length];
            this.data[this.length] = default(T);
            return lastElement;
        }

        public void Push(T element)
        {
            if (this.length >= this.data.Length)
            {
                Array.Resize(ref this.data, this.data.Length * 2);
            }

            this.data[this.length] = element;
            this.length++;
        }

        public void Push(IEnumerable<T> elements)
        {
            foreach (var item in elements)
            {
                this.Push(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.length - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
