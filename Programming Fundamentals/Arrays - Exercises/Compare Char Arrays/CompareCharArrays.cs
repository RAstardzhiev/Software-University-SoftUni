namespace Compare_Char_Arrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            char[] charr1 = StringToChar(first);
            char[] charr2 = StringToChar(second);

            int sum1 = SumCharArray(charr1);
            int sum2 = SumCharArray(charr2);

            if (sum1 < sum2)
            {
                foreach (var item in charr1)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
                foreach (var item in charr2)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
            else
            {
                foreach (var item in charr2)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
                foreach (var item in charr1)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
        }

        public static int SumCharArray(char[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (int)arr[i];
            }

            return sum;
        }

        public static char[] StringToChar(string s)
        {
            int spaceCount = 0;
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    spaceCount++;
                }
            }

            char[] ch = new char[s.Length - spaceCount];
            for (int i = 0, j = 0; j < ch.Length; i++)
            {
                if (s[i] != ' ')
                {
                    ch[j] = s[i];
                    j++;
                }
            }

            return ch;
        }
    }
}
