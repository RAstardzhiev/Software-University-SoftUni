namespace _7.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = GetValidUsernames();
            Console.WriteLine(GetResult(usernames));
        }

        private static string GetResult(Queue<string> usernames)
        {
            var maxLength = 0;
            var winningUsernames = new string[2];

            while (usernames.Count > 1)
            {
                var firstUser = usernames.Dequeue();
                var testLength = firstUser.Length + usernames.Peek().Length;

                if (testLength > maxLength)
                {
                    maxLength = testLength;
                    winningUsernames[0] = firstUser;
                    winningUsernames[1] = usernames.Peek();
                }
            }

            return $"{winningUsernames[0]}{Environment.NewLine}{winningUsernames[1]}";
        }

        private static Queue<string> GetValidUsernames()
        {
            var input = Console.ReadLine().Split(new char[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var usernames = new Queue<string>();

            var regex = new Regex(@"^[A-Za-z]\w{2,24}$");

            foreach (var item in input)
            {
                if (regex.IsMatch(item))
                {
                    usernames.Enqueue(item);
                }
            }

            return usernames;
        }
    }
}
