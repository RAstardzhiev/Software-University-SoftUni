namespace _1.Students_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine()); ;
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                AddStudent(students);
            }

            PrintStudents(students);
        }

        private static void PrintStudents(Dictionary<string, List<double>> students)
        {
            var sb = new StringBuilder();

            sb.Append("Name      |   CAdv|   COOP| AdvOOP|Average|");
            sb.Append(Environment.NewLine);

            foreach (var student in students)
            {
                sb.Append($"{student.Key, -10}|");

                sb.Append($"{student.Value[0], 7:F2}|");
                sb.Append($"{student.Value[1], 7:F2}|");
                sb.Append($"{student.Value[2], 7:F2}|");
                sb.Append($"{student.Value.Average(), 7:F4}|");

                sb.Append(Environment.NewLine);
            }

            Console.Write(sb.ToString());
        }

        private static void AddStudent(Dictionary<string, List<double>> students)
        {
            var input = Console.ReadLine();

            var indexOfSeparation = input.IndexOf(" - ");

            if (indexOfSeparation < 0)
            {
                return;
            }

            var name = input.Substring(0, indexOfSeparation).Trim();
            var results = input
                .Substring(indexOfSeparation + 2)
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            if (results.Count() != 3)
            {
                return;
            }

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }

            students[name].AddRange(results);
        }
    }
}
