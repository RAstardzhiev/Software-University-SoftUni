namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;

        // Dictionary<courseName, Dictionary<userName, scores>>
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");

                foreach (var studentMarksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMarksEntry);
                }
            }
        }

        public static void GetStudentScoresFromCourse(string courseName, string userName)
        {
            if (IsQueryForStudentPossiblе(courseName, userName))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(userName, studentsByCourse[courseName][userName]));
            }
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (!studentsByCourse.ContainsKey(courseName))
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                    return false;
                }

                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private static bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public static void InitializeData(string fileName = null)
        {
            if (!isDataInitialized)
            {
                if (fileName != null)
                {
                    ReadData(fileName);
                    return;
                }

                OutputWriter.WriteMessageOnNewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData();
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        private static void ReadData()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split(' ');

                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse[course] = new Dictionary<string, List<int>>();
                }

                if (!studentsByCourse[course].ContainsKey(student))
                {
                    studentsByCourse[course][student] = new List<int>();
                }

                studentsByCourse[course][student].Add(mark);
                input = Console.ReadLine();
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static void ReadData(string fileName)
        {
            string path = $"{SessionData.currentPath}\\{fileName}";

            if (File.Exists(path))
            {
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]))
                    {
                        string[] data = allInputLines[line].Split(' ');

                        string course = data[0];
                        string student = data[1];
                        int mark = int.Parse(data[2]);

                        if (!studentsByCourse.ContainsKey(course))
                        {
                            studentsByCourse[course] = new Dictionary<string, List<int>>();
                        }

                        if (!studentsByCourse[course].ContainsKey(student))
                        {
                            studentsByCourse[course][student] = new List<int>();
                        }

                        studentsByCourse[course][student].Add(mark);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                    }
                }
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }
    }
}
