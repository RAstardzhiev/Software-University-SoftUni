namespace _10.Create_Custom_Class_Attribute
{
    using System;
    using System.Linq;
    using Attributes;

    [Info("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class StartUp
    {
        public static void Main()
        {
            var attr = (InfoAttribute)typeof(StartUp).GetCustomAttributes(false).First();

            var command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attr.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attr.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attr.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attr.Reviewers)}");
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
