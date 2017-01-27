namespace Sieve_of_Eratosthenes
{
    using System;
    using System.Collections.Generic;

    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                primes.Add(i);
            }

            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = i + 1; j < primes.Count; j++)
                {
                    if (primes[j] % primes[i] == 0)
                    {
                        primes.RemoveAt(j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", primes));
        }
    }
}
