namespace Lists
{
    public class Startup
    {
        public static void Main()
        {
            var list = new ArrayList<int>();
            list.Add(5);
            list[0] = list[0] + 1;
            var element = list.RemoveAt(0);
        }
    }
}
