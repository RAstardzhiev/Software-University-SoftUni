namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Photos;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(StudentSystemContext context)
        {
            this.MainModelsSeed(context);
            this.PhotographersSeed(context);
            this.PhotosSeed(context);
        }

        private void PhotosSeed(StudentSystemContext context)
        {
            if (context.Albums.Count() > 0)
            {
                return;
            }

            var firstPic = new Picture("One", "First Pic", @"..\..\Pics\First pic.jpg");
            var secondPic = new Picture("Two", "Second Pic", @"..\..\Pics\Second pic.jpg");
            var thirdPic = new Picture("Three", "Third Pic", @"..\..\Pics\Third pic.jpg");
            var fourthPic = new Picture("Four", "Fourth Pic", @"..\..\Pics\Fourth pic.jpg");
            var fifthPic = new Picture("Five", "Fifth Pic", @"..\..\Pics\Fifth pic.jpg");

            foreach (var photographer in context.Photographers.Take(10))
            {
                var album = new Album($"{photographer.UserName}'s Album", "Red", true);
                album.Pictures.Add(firstPic);
                album.Pictures.Add(secondPic);
                album.Pictures.Add(thirdPic);
                album.Pictures.Add(fourthPic);
                album.Pictures.Add(fifthPic);

                photographer.Albums.Add(album);
            }

            context.SaveChanges();
        }

        private void PhotographersSeed(StudentSystemContext context)
        {
            if (context.Photographers.Count() > 0)
            {
                return;
            }

            var pOne = new Photographer("PhotoSnake", "ksksksks555", "PhotoSnake@abv.bg");
            var pTwo = new Photographer("PhotoFreak", "ihjbsdfjsd", "sdjfbsdikjbkg@abv.bg");
            var pThree = new Photographer("PhotoMania", "sdggdasfgdfh", "sdgfsdgdfgdf@abv.bg");

            context.Photographers.AddOrUpdate(new[] { pOne, pTwo, pThree });
            context.SaveChanges();
        }

        private void MainModelsSeed(StudentSystemContext context)
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
