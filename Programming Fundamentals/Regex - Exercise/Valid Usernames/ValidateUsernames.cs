namespace Valid_Usernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ValidateUsernames
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[a-zA-Z]\w{2,24}$");
            string[] users = Console.ReadLine()
                .Split("\\/() ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim("\t\r\n\"'<>,./\\=+-()*&^%$#@!?".ToCharArray()))
                .Where(x => regex.IsMatch(x))
                .ToArray();

            Console.WriteLine(TwoBiggestLenghts(users));
        }

        private static string TwoBiggestLenghts(string[] users)
        {
            if (users.Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (users.Length <= 2)
            {
                return string.Join(Environment.NewLine, users);
            }

            string firstUser = users[0];
            string secondUser = users[1];
            int sum = users[0].Length + users[1].Length;

            for (int i = 2; i < users.Length; i++)
            {
                if (users[i].Length + users[i - 1].Length > sum)
                {
                    sum = users[i].Length + users[i - 1].Length;
                    firstUser = users[i - 1];
                    secondUser = users[i];
                }
            }

            return firstUser + Environment.NewLine + secondUser;
        }
    }
}