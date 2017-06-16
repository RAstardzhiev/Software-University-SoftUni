namespace _3.First_Name
{
    using System;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine().ToLower().ToCharArray().Where(c => c != ' ').ToArray();

            var filteredNames = names.Where(n => letters.Contains(char.ToLower(n[0]))).ToArray();

            Console.WriteLine((filteredNames.Length == 0)
                ? "No match"
                : filteredNames.OrderBy(n => n).First());
        }
    }
}
