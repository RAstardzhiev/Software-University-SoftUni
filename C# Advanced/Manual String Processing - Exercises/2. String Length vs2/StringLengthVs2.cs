namespace _2.String_Length_vs2
{
    using System;

    public class StringLengthVs2
    {
        public static void Main()
        {
            var str = Console.ReadLine();

            if (str.Length > 20)
            {
                str = str.Substring(0, 20);
            }

            Console.WriteLine($"{str.PadRight(20, '*')}");
        }
    }
}
