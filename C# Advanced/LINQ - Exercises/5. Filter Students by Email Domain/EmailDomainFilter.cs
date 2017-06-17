namespace _5.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;

    public class EmailDomainFilter
    {
        private const string TargetEmail = "@gmail.com";

        public static void Main()
        {
            var students = GetStudents(str => str.EndsWith(TargetEmail));
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }

        private static List<string> GetStudents(Func<string, bool> filter)
        {
            var students = new List<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace > 0)
                {
                    if (filter(input))
                    {
                        students.Add(input.Substring(0, indexOfLastSpace));
                    }
                }

                input = Console.ReadLine();
            }

            return students;
        }
    }
}
