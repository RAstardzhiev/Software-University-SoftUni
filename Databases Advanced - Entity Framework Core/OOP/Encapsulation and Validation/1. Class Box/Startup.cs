namespace _1.Class_Box
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            ReflectionFieldChecker();
            var box = GetBoxFromConsole();

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.GetVolume():F2}");
        }

        private static Box GetBoxFromConsole()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = null;

            try
            {
                box = new Box(length, height, width);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(Environment.ExitCode);
            }

            return box;
        }

        private static void ReflectionFieldChecker()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
        }
    }
}
