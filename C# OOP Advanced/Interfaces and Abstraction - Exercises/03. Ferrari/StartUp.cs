namespace _03.Ferrari
{
    using Cars;
    using System;

    public class StartUp
    {
        private const string Model = "488-Spider";

        public static void Main()
        {
            var driver = Console.ReadLine();
            var car = new Ferrari(driver, Model);
            Console.WriteLine(car);

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
