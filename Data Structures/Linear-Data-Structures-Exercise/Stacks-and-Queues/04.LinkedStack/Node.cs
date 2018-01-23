namespace _04.LinkedStack
{
    public class Node<T>
    {
        public Node(T value, Node<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }

        public Node<T> NextNode { get; set; }

        public T Value { get; set; }
    }
}
