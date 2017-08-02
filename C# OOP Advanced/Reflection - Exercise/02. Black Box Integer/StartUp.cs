namespace _02.Black_Box_Integer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(new BlackBoxIntegerTests().Run(typeof(BlackBoxInt)));
        }
    }
}
