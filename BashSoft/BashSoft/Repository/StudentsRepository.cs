namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Execptions;
    using Models;

    public class StudentsRepository
    {
        private bool isDataInilized;
        private Dictionary<string, Course> courses;
        private Dictionary<string, Student> students;
        private RepositoryFilter filter;
        private RepositorySorter sorter;

        public StudentsRepository(RepositoryFilter filter, RepositorySorter sorter)
        {
            this.courses = new Dictionary<string, Course>();
            this.students = new Dictionary<string, Student>();
            this.filter = filter;
            this.sorter = sorter;
            this.isDataInilized = false;
        }

        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                var marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);
                this.filter.FilterAndTake(marks, givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                var marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);
                this.sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
            }
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInilized)
            {
                throw new ArgumentException(ExceptionMessages.DataAlreadyInitialisedException);
            }
            
            this.courses = new Dictionary<string, Course>();
            this.students = new Dictionary<string, Student>();
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            ReadData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInilized)
            {
                throw new ArgumentException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            this.courses = null;
            this.students = null;
            this.isDataInilized = false;
        }

        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                var rgx = new Regex(@"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)");
                var allInputLines = File.ReadAllLines(path);
                for (int i = 0; i < allInputLines.Length; i++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[i]) && rgx.IsMatch(allInputLines[i]))
                    {
                        var currentMatch = rgx.Match(allInputLines[i]);
                        var courseName = currentMatch.Groups[1].Value;
                        var username = currentMatch.Groups[2].Value;
                        var scoreStr = currentMatch.Groups[3].Value;

                        try
                        {
                            var scores = scoreStr.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                            if (scores.Any(s => s > 100 && s < 0))
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidScore);
                                continue;
                            }

                            if (scores.Length > Course.NumberOfTasksOnExam)
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }

                            if (!this.students.ContainsKey(username))
                            {
                                this.students.Add(username, new Student(username));   
                            }

                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName, new Course(courseName));
                            }

                            var course = this.courses[courseName];
                            var student = this.students[username];

                            student.EnrollInCourse(course);
                            student.SetMarkOnCourse(courseName, scores);
                            course.EnrollStudent(student);
                            
                        }
                        catch (FormatException fex)
                        {
                            OutputWriter.DisplayException(fex.Message + $"at line : {i}");
                        }
                    }
                }
            }
            else
            {
                throw new InvalidPathException();
            }

            isDataInilized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInilized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (this.IsQueryForCoursePossible(courseName) && this.courses[courseName].StudentsByName.ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public void GetStudentScoresFromCourse(string courseName, string username)
        {
            OutputWriter.PrintStudent(
                new KeyValuePair<string, double>(username, this.courses[courseName].StudentsByName[username].MarksByCourseName[courseName]));
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");
                foreach (var studetMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentScoresFromCourse(courseName, studetMarksEntry.Key);
                }
            }
        }
    }
}