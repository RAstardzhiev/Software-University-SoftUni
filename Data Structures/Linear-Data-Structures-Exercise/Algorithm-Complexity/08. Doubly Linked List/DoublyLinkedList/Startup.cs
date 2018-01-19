namespace Double_Linked_List
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var list = new DoublyLinkedList<int>();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.AddLast(5);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddLast(10);
            Console.WriteLine("Count = {0}", list.Count);

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.RemoveFirst();
            list.RemoveLast();
            list.RemoveFirst();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.RemoveLast();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");
        }
    }
}
