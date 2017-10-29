namespace _3.Mankind
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var student = GetStudentFromConsole();
                var worker = GetWorkerFromConsole();
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Worker GetWorkerFromConsole()
        {
            var input = Console.ReadLine().Split();
            var firstName = input[0];
            var lastName = input[1];
            var weekSalary = decimal.Parse(input[2]);
            var workHoursPerDay = double.Parse(input[3]);

            return new Worker(firstName, lastName, weekSalary, workHoursPerDay);
        }

        private static Student GetStudentFromConsole()
        {
            var input = Console.ReadLine().Split();
            var firstName = input[0];
            var lastName = input[1];
            var facultyNumber = input[2];

            return new Student(firstName, lastName, facultyNumber);
        }
    }
}
