using System;

namespace Comparing_floats
{
    public class Comparing_floats
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(float.MaxValue);
            float eps = 0.000001F;
            //Console.WriteLine(eps);
            eps -= 0.0000001F;
            //Console.WriteLine(eps);
            float n1 = (float)float.Parse(Console.ReadLine());
            float n2 = (float)float.Parse(Console.ReadLine());
            Console.WriteLine((n1 < n2 + eps && n1 >= n2 || n1 > n2 - eps && n1 <= n2) ? "True" : "False");
        }
    }
}
