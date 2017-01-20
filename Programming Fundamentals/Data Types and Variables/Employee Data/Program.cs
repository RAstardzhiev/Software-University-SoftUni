using System;

namespace Employee_Data
{
    public class Employee_Data
    {
        public static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            //Console.WriteLine(int.MaxValue);
            long personalID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}\n" +
                "Last name: {1}\n" +
                "Age: {2}\n" +
                "Gender: {3}\n" +
                "Personal ID: {4}\n" +
                "Unique Employee number: {5}\n", firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
