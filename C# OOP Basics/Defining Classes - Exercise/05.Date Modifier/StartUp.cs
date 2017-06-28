namespace _05.Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
