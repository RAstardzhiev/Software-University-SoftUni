namespace _03.Mankind
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            GetHumans();
        }

        private static void GetHumans()
        {
            var studentData = Console.ReadLine().Split();
            var werkerData = Console.ReadLine().Split();

            try
            {
                var student = new Student(studentData[0], studentData[1], studentData[2]);
                var worker = new Worker(werkerData[0], werkerData[1], decimal.Parse(werkerData[2]), double.Parse(werkerData[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
