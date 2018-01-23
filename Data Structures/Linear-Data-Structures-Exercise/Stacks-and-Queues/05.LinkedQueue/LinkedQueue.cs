namespace _05.LinkedQueue
{
    using System;

    public class LinkedQueue<T>
    {
        public Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                var node = new Node<T>(element, this.tail);
                this.tail.NextNode = node;
                this.tail = node;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedElement = this.head.Value;
            this.head = this.head.NextNode;
            this.Count--;

            return removedElement;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            var currentNode = this.head;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

    }
}
