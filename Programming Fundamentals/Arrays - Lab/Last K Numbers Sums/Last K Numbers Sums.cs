namespace Last_K_Numbers_Sums
{
    using System;

    public class Last_K_Numbers_Sums
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0L;
                if (i < k)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        sum += array[j];
                    }
                }
                else
                {
                    for (int j = i - k; j < array.Length; j++)
                    {
                        sum += array[j];
                    }
                }

                array[i] = sum;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
