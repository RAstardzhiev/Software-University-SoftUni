namespace _7.Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcellentStudents
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine,
                GetStudentsData()
                .Where(st => st.Contains("6"))
                .Select(st => st
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(name => string.Join(" ", name.Where(w => char.IsLetter(w[0]))))));
        }

        private static List<string> GetStudentsData()
        {
            var studentsData = new List<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                studentsData.Add(input);

                input = Console.ReadLine();
            }

            return studentsData;
        }
    }
}
