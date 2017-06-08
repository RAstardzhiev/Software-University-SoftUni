namespace _7.Valid_Time
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main()
        {
            var regex = new Regex(@"\b(0?[0-9]|1[0-2])(:[0-5]?[0-9]){2}\s?(A|P)M\b");

            var time = Console.ReadLine();

            while (time != "END")
            {
                Console.WriteLine(regex.IsMatch(time) ? "valid" : "invalid");

                time = Console.ReadLine();
            }
        }
    }
}
