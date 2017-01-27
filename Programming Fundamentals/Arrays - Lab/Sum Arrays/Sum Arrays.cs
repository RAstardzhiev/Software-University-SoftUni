namespace Sum_Arrays
{
    using System;

    public class Sum_Arrays
    {
        public static void Main(string[] args)
        {
            string[] row1 = Console.ReadLine().Split();
            string[] row2 = Console.ReadLine().Split();

            int[] arr1 = new int[row1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(row1[i]);
            }

            int[] arr2 = new int[row2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(row2[i]);
            }

            for (int i = 0, j = 0, k = 0; k < Math.Max(arr1.Length, arr2.Length); i++, j++, k++)
            {
                if (i == arr1.Length)
                {
                    i = 0;
                }

                if (j == arr2.Length)
                {
                    j = 0;
                }

                Console.Write("{0} ", arr1[i] + arr2[j]);
            }
        }
    }
}
