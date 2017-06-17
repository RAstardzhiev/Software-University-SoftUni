namespace _3.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
    {
        private const int MinAge = 18;
        private const int MaxAge = 24;

        public static void Main()
        {
            var studentsNameAge = GetStudents();
            Console.WriteLine(string.Join(Environment.NewLine, studentsNameAge
                .Where(kvp => kvp.Value >= MinAge && kvp.Value <= MaxAge)
                .Select(kvp => $"{kvp.Key} {kvp.Value}")));
        }

        private static Dictionary<string, int> GetStudents()
        {
            var students = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace >= 1)
                {
                    int age;
                    var isValid = int.TryParse(input.Substring(indexOfLastSpace + 1), out age);

                    if (isValid)
                    {
                        students[input.Substring(0, indexOfLastSpace)] = age;
                    }
                }

                input = Console.ReadLine();
            }

            return students;
        }
    }
}
