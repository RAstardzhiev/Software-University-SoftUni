namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new Node<T> { Value = item };

            if (this.Count == 0)
            {
                this.Tail = this.Head = node;
            }
            else if (this.Count == 1)
            {
                this.Head = node;
                this.Head.Next = this.Tail;
                this.Tail.Previous = this.Head;
            }
            else
            {
                node.Next = this.Head;
                this.Head.Previous = node;
                this.Head = node;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            var node = new Node<T> { Value = item };

            if (this.Count == 0)
            {
                this.Head = this.Tail = node;
            }
            else if (this.Count == 1)
            {
                this.Tail = node;
                this.Tail.Previous = this.Head;
                this.Head.Next = node;
            }
            else
            {
                node.Previous = this.Tail;
                this.Tail.Next = node;
                this.Tail = node;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedItem = this.Head.Value;

            if (this.Count == 1)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                this.Head = this.Head.Next;
                this.Head.Previous = null;
            }

            this.Count--;

            return removedItem;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedItem = this.Tail.Value;

            if (this.Count == 1)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                this.Tail = this.Tail.Previous;
                this.Tail.Next = null;
            }

            this.Count--;

            return removedItem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.Head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
