namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentSystemContext context)
        {
            if (context.Courses.Count() > 0)
            {
                return;
            }

            var studentOne = new Student("FirstStudent", DateTime.Now);
            var studentTwo = new Student("SecondStudent", DateTime.Now);
            var studentThree = new Student("ThirdStudent", DateTime.Now);

            var homeworkOne = new Homework("https://softuni.bg/csharp/homeworks/12345", "ZIP", DateTime.Now, studentOne);
            var homeworkTwo = new Homework("https://softuni.bg/java/homeworks/12345", "ZIP", DateTime.Now, studentTwo);
            var homeworkThree = new Homework("https://softuni.bg/csharp/homeworks/4567", "ZIP", DateTime.Now, studentThree);

            var cSharpResourceOne = new Resource("Generics", "Exercises", "https://softuni.bg/csharp/123");
            var cSharpResourceTwo = new Resource("Generics", "Presentation", "https://softuni.bg/csharp/456");
            var javaResourceOne = new Resource("Matrices", "Exercises", "https://softuni.bg/java/123");
            var javaResourceTwo = new Resource("Matrices", "Presentation", "https://softuni.bg/java/456");

            var courseCSharp = new Course("C# Advanced", DateTime.Now, DateTime.Now.AddMonths(4), 400M);
            courseCSharp.Resources.Add(cSharpResourceOne);
            courseCSharp.Resources.Add(cSharpResourceTwo);
            courseCSharp.Students.Add(studentOne);
            courseCSharp.Students.Add(studentThree);
            courseCSharp.Homeworks.Add(homeworkOne);
            courseCSharp.Homeworks.Add(homeworkThree);

            var courseJava = new Course("Java Advanced", DateTime.Now, DateTime.Now.AddMonths(4), 400M);
            courseJava.Resources.Add(javaResourceOne);
            courseJava.Resources.Add(javaResourceTwo);
            courseJava.Students.Add(studentTwo);
            courseJava.Homeworks.Add(homeworkTwo);

            context.Courses.AddOrUpdate(new[] { courseCSharp, courseJava });
            context.SaveChanges();
        }
    }
}
