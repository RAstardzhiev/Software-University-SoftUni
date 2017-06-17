namespace _11.Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsSpecialties
    {
        public static void Main()
        {
            var specialities = GetSpecialities();
            var students = GetStudents();

            var studentSpecialities = students.Join(specialities,
                    st => st.Faculty,
                    sp => sp.Faculty,
                    (st, sp) => new
                    {
                        Name = st.Name,
                        Faculty = st.Faculty,
                        Speciality = sp.Name
                    });

            Console.WriteLine(string.Join(Environment.NewLine, studentSpecialities
                .OrderBy(st => st.Name)
                .Select(st => $"{st.Name} {st.Faculty} {st.Speciality}")));
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine().Trim();

            while (input != "END")
            {
                var indexOfFirstSpace = input.IndexOf(' ');

                if (indexOfFirstSpace > 0)
                {
                    students.Add(new Student
                    {
                        Name = input.Substring(indexOfFirstSpace + 1).Trim(),
                        Faculty = input.Substring(0, indexOfFirstSpace).Trim()
                    });
                }

                input = Console.ReadLine().Trim();
            }

            return students;
        }

        private static List<StudentSpecialty> GetSpecialities()
        {
            var specialities = new List<StudentSpecialty>();
            var input = Console.ReadLine().Trim();

            while (input != "Students:")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace > 0)
                {
                    specialities.Add(new StudentSpecialty
                    {
                        Name = input.Substring(0, indexOfLastSpace).Trim(),
                        Faculty = input.Substring(indexOfLastSpace + 1).Trim()
                    });
                }

                input = Console.ReadLine().Trim();
            }

            return specialities;
        }
    }
}
