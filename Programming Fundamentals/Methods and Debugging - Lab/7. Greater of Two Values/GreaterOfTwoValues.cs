namespace Greater_of_Two_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GreaterOfTwoValues
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "byte":
                case "short":
                case "ushort":
                case "int": GreaterInt();
                    break;
                case "float":
                case "double": GreaterDouble();
                    break;
                case "char": GreaterChar();
                    break;
                case "string": GreaterString();
                    break;
                default:
                    break;
            }
        }

        private static void GreaterString()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (string.Compare(s1, s2) < 0)
            {
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine(s1);
            }
        }

        private static void GreaterChar()
        {
            char c1 = Console.ReadLine()[0];
            char c2 = Console.ReadLine()[0];
            Console.WriteLine((c1 > c2) ? c1 : c2);
        }

        private static void GreaterDouble()
        {
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(d1, d2));
        }

        private static void GreaterInt()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(n1, n2));
        }
    }
}
