namespace Double_Linked_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public void AddFirst(T element)
        {
            var node = new Node<T> { Value = element };

            if (this.Count == 0)
            {
                this.Head = this.Tail = node;
                this.Count++;
                return;
            }

            if (this.Count == 1)
            {
                this.Tail.Previous = node;
            }

            node.Next = this.Head;
            this.Head.Previous = node;
            this.Head = node;

            this.Count++;
        }

        public void AddLast(T element)
        {
            var node = new Node<T> { Value = element };

            if (this.Count == 0)
            {
                this.Head = this.Tail = node;
                this.Count++;
                return;
            }

            if (this.Count == 1)
            {
                this.Head.Next = node;
            }

            node.Previous = this.Tail;
            this.Tail.Next = node;
            this.Tail = node;

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedValue = this.Head.Value;

            if (this.Count == 1)
            {
                this.Head = this.Tail = null;
                this.Count--;

                return removedValue;
            }

            this.Head = this.Head.Next;
            this.Head.Previous = null;
            this.Count--;

            return removedValue;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedValue = this.Tail.Value;

            if (this.Count == 1)
            {
                this.Head = this.Tail = null;
                this.Count--;
                return removedValue;
            }

            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
            this.Count--;

            return removedValue;
        }

        public void ForEach(Action<T> action)
        {
            foreach (var item in this)
            {
                action(item);
            }
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

        public T[] ToArray()
        {
            var currentNode = this.Head;

            var arr = new T[this.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }
    }
}
