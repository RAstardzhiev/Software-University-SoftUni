namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1: // 1 someString - appends someString to the end of the text
                        if (input.Length > 1)
                        {
                            history.Push(text.ToString());
                            text.Append(input[1]);
                        }

                        break;
                    case 2: // 2 count - erases the last count elements from the text
                        if (input.Length > 1)
                        {
                            var count = int.Parse(input[1]);
                            history.Push(text.ToString());

                            if (count > text.Length)
                            {
                                text.Clear();
                                break;
                            }

                            text.Remove(text.Length - count, count);
                        }

                        break;
                    case 3: // 3 index - returns the element at position index from the text
                        if (input.Length > 1)
                        {
                            var index = int.Parse(input[1]);

                            if (index <= text.Length && index > 0)
                            {
                                Console.WriteLine(text[index - 1]);
                            }
                        }

                        break;
                    case 4: // 4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
                        text.Clear();
                        text.Append(history.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
