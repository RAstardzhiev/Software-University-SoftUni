namespace _04.LinkedStack
{
    using System;

    public class LinkedStack<T>
    {
        private Node<T> firstNode;

        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedNode = this.firstNode;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;

            return removedNode.Value;
        }

        public T[] ToArray()
        {
            var currentNode = this.firstNode;

            var array = new T[this.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

    }
}