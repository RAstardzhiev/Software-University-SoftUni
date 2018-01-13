namespace LinkedList
{
    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.AddFirst(i);
            }

            for (int i = 0; i < 100; i++)
            {
                list.RemoveLast();
            }
        }
    }
}