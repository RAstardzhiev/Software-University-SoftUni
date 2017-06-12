namespace _1.Action_Print
{
    using System;

    public class ActionPrint
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            // Both variations are EQUAL
            Action<string[]> action = Print;
            action(input);

            Console.WriteLine();

            // Both variations are EQUAL
            //Action<string[]> lambdaAction = arr => Console.WriteLine(string.Join(Environment.NewLine, arr));
            //lambdaAction(input);
        }

        public static void Print(string[] array)
        {
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
