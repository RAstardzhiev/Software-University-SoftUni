namespace _8.Weak_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WeakStudents
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, GetStudents()
                .Where(s => s.Evaluations.Where(n => n <= 3).Count() >= 2)
                .Select(s => s.Name)));
        }

        private static Queue<Studednt> GetStudents()
        {
            var students = new Queue<Studednt>();

            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                var name = string.Join(" ", input.Where(w => char.IsLetter(w[0])));
                var evaluations = input
                    .Where(w => char.IsDigit(w[0]))
                    .Select(double.Parse);

                var currentStudent = new Studednt
                {
                    Name = name,
                    Evaluations = new List<double>(evaluations)
                };

                if (students.Contains(currentStudent))
                {
                    var studetToUpdate = students.Where(s => s.Equals(currentStudent)).First();
                    studetToUpdate.Evaluations = studetToUpdate.Evaluations.Concat(evaluations).ToList();
                }
                else
                {
                    students.Enqueue(currentStudent);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }
    }
}
