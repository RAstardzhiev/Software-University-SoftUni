namespace Largest_Common_End
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int leftToRight = 0, rightToLeft = 0, minLength = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i].Equals(arr2[i]))
                {
                    leftToRight++;
                    continue;
                }

                break;
            }

            for (int i = 1; i <= minLength; i++)
            {
                if (arr1[arr1.Length - i].Equals(arr2[arr2.Length - i]))
                {
                    rightToLeft++;
                    continue;
                }

                break;
            }

            Console.WriteLine(Math.Max(leftToRight, rightToLeft));
        }
    }
}
