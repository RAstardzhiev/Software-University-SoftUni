namespace _5.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            while (true)
            {
                var command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "stop":
                        return;
                    case "search":

                        command = Console.ReadLine();

                        while (command.ToLower() != "stop")
                        {
                            Console.WriteLine(phoneBook.ContainsKey(command) 
                                ? $"{command} -> {phoneBook[command]}"
                                : $"Contact {command} does not exist.");

                            command = Console.ReadLine();
                        }

                        return;
                    default:
                        break;
                }

                var separator = command.IndexOf('-');

                if (separator > 0)
                {
                    var name = command.Substring(0, separator);
                    var number = command.Substring(separator + 1);
                    phoneBook[name] = number;
                }
            }
        }
    }
}
