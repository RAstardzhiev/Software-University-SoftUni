namespace Library
{
    using System;

    using System.Collections.Generic;

    public static class StudentsRepository
    {
        public static bool IsDataInitialized = false;

        // Dictionary<course_name, Dictionary<user_name, scores>>
        private static Dictionary<string, Dictionary<string, List<int>>> StudentsByCourse;

        // Fill Dictionary
        public static void InitializeData()
        {
            if (!IsDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
                StudentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData();
                IsDataInitialized = true;
                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitializedException);
            }
        }

        // Fill Dictionary from Console
        private static void ReadData()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split();
                string course = tokens[0];
                string student = tokens[1];
                int score = int.Parse(tokens[2]);

                // Add data to the collection
                if (!StudentsByCourse.ContainsKey(course))
                {
                    StudentsByCourse[course] = new Dictionary<string, List<int>>();
                }

                if (!StudentsByCourse[course].ContainsKey(student))
                {
                    StudentsByCourse[course][student] = new List<int>();
                }

                StudentsByCourse[course][student].Add(score);

                input = Console.ReadLine();
            }
        }

        // Check whether Course exists in database
        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (IsDataInitialized)
            {
                if (StudentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }

                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InexistentCourseInDatabase);
            }

            OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataNotInitializedExceptionMessage);

            return false;
        }

        // Check whether Student exists in database
        private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && StudentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }

            OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InexistentStudentInDatabase);
            return false;
        }

        // Print / Display
        public static void GetStudentScoresFromCourse(string courseName, string userName)
        {
            if (IsQueryForStudentPossible(courseName, userName))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(userName, StudentsByCourse[courseName][userName]));
            }
        }

        // Print / Display
        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");

                foreach (var student in StudentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(student);
                }
            }
        }
    }
}
