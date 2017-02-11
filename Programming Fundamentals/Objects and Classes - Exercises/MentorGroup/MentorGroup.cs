namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main(string[] args)
        {
            List<Student> students = GetStudents();
            PrintStudentReport(students);
        }

        private static void PrintStudentReport(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Comment.Count == 0 ? "Comments:" : $"Comments:\n- {string.Join("\n- ", student.Comment)}");
                Console.WriteLine((student.AttendedDates.Count < 1) ? "Dates attended:" : $"Dates attended:\n-- {string.Join("\n-- ", student.AttendedDates.Select(x => x.ToString("dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)))}");
            }
        }

        private static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("end of dates"))
                {
                    break;
                }

                string[] nameAndDates = input.Split();
                students = SetStudent(nameAndDates, students);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0].ToLower().Equals("end of comments"))
                {
                    break;
                }

                if (input.Any(x => x.Contains('/')))
                {
                    students = SetStudent(input, students);
                    continue;
                }

                foreach (Student student in students)
                {
                    if (student.Name.Equals(input[0]))
                    {
                        student.Comment.Add(input[1]);
                    }
                }
            }

            students = students.OrderBy(x => x.Name).ToList();
            foreach (Student student in students)
            {
                student.AttendedDates = student.AttendedDates
                    .OrderBy(x => x)
                    .ToList();
            }

            return students;
        }

        private static List<Student> SetStudent(string[] nameAndDates, List<Student> students)
        {
            if (nameAndDates.Length == 1)
            {
                students.Add(new Student() { Name = nameAndDates[0] });
                return students;
            }
            else
            {
                if (students.Any(x => x.Name.Equals(nameAndDates[0])))
                {
                    foreach (Student student in students)
                    {
                        if (student.Name.Equals(nameAndDates[0]))
                        {
                            student.AttendedDates.AddRange(nameAndDates[1].Split(',').Select(x => DateTime.ParseExact(x, "d/M/yyyy", CultureInfo.InvariantCulture)).ToList());
                            break;
                        }
                    }
                }
                else
                {
                    Student temp = new Student();
                    temp.Name = nameAndDates[0];
                    temp.AttendedDates = nameAndDates[1]
                        .Split(',')
                        .Select(x => DateTime.ParseExact(x, "d/M/yyyy", CultureInfo.InvariantCulture))
                        .ToList();

                    students.Add(temp);
                }
            }

            return students;
        }
    }
}
