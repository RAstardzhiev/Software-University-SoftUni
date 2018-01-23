namespace _05.LinkedQueue
{
    public class Node<T>
    {
        public Node(T value, Node<T> prevNode = null)
        {
            this.Value = value;
            this.PrevNode = prevNode;
        }

        public T Value { get; private set; }

        public Node<T> NextNode { get; set; }

        public Node<T> PrevNode { get; set; }
    }
}
