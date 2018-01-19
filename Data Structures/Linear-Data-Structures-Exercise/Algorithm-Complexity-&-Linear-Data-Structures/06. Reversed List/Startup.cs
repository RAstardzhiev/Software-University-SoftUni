namespace _06.Reversed_List
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var list = new ReversedList<int>();

            Console.WriteLine(list.Capacity);

            for (int i = 1; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list[1]);
            Console.WriteLine(list.RemoveAt(1));
            Console.WriteLine(string.Join(" ", list));
            list.Add(1);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
