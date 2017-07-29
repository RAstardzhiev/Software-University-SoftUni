namespace _09.Linked_List_Traversal.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> firstElement;

        public LinkedList()
        {
        }

        public LinkedList(T item)
        {
            var currentNode = new LinkedListNode<T>(item);
            this.Head = currentNode;
            this.firstElement = currentNode;
            this.Count = 1;
        }

        public int Count { get; private set; }

        public LinkedListNode<T> Head { get; private set; }

        public void Add(T item)
        {
            var currentNode = new LinkedListNode<T>(item);

            if (this.Count == 0)
            {
                this.Head = currentNode;
                this.firstElement = currentNode;
            }
            else
            {
                this.Head.Next = currentNode;
                currentNode.Prev = this.Head;
                this.Head = currentNode;
            }

            this.Count++;
        }

        public bool Remove(T key)
        {
            var currentNode = this.firstElement;

            if (this.Count == 1)
            {
                this.Clear();
            }

            while (currentNode.Next != null)
            {
                if (currentNode.Item.Equals(key))
                {
                    if (currentNode.Prev != null)
                    {
                        currentNode.Prev.Next = currentNode.Next;
                    }
                    else
                    {
                        this.firstElement = this.firstElement.Next;
                        this.firstElement.Prev = null;
                    }

                    if (currentNode.Next != null)
                    {
                        currentNode.Next.Prev = currentNode.Prev;
                    }
                    else
                    {
                        currentNode.Prev.Next = null;
                    }

                    this.Count--;
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public void Clear()
        {
            this.firstElement = null;
            this.Head = null;
            this.Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.firstElement;

            while (currentNode != null)
            {
                yield return currentNode.Item;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
