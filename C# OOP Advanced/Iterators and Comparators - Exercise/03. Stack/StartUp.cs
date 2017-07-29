namespace _03.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<int>();
            ExecuteCommands(stack);
        }

        private static void ExecuteCommands(Stack<int> stack)
        {
            var cmdArgs = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Push":
                        var elements = cmdArgs.Skip(1).Select(int.Parse);
                        stack.Push(elements);
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }

                        break;
                    default:
                        break;
                }

                cmdArgs = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            PrintStack(stack);
            PrintStack(stack);
        }

        private static void PrintStack(Stack<int> stack)
        {
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
