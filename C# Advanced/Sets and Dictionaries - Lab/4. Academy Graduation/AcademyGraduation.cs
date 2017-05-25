namespace _4.Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class AcademyGraduation
    {
        public static void Main()
        {
            var students = ReadInput();
            Console.WriteLine(string.Join(Environment.NewLine, students
                .Select(s => $"{s.Key} is graduated with {s.Value.Average()}")));
        }

        private static SortedDictionary<string, Stack<double>> ReadInput()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, Stack<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n, CultureInfo.InvariantCulture));

                if (!students.ContainsKey(name))
                {
                    students[name] = new Stack<double>();
                }

                foreach (var score in grades)
                {
                    students[name].Push(score);
                }
            }

            return students;
        }
    }
}
