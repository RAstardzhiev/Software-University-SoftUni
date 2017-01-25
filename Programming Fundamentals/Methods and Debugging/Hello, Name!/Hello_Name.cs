namespace Hello__Name_
{
    using System;

    public class Hello_Name
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloToName(name);
        }

        private static void PrintHelloToName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
