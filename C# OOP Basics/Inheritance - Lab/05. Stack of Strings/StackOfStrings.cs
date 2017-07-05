namespace _05.Stack_of_Strings
{
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings
    {
        private List<string> collection;

        public void Push(string item)
        {
            this.collection.Add(item);
        }

        public string Pop()
        {
            var result = this.collection.Last();
            this.collection.RemoveAt(this.collection.Count - 1);
            return result;
        }

        public string Peek()
        {
            return this.collection.Last();
        }

        public bool IsEmpty()
        {
            return this.collection.Count == 0;
        }
    }
}