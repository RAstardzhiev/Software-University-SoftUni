using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            calculate(action, n1, n2);
        }
        public static void calculate(char action, int n1, int n2)
        {
            // Separator
            if (action == '/')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.WriteLine($"{n1} / {n2} = {n1 * 1.0 / n2:f2}");
            }
            else if (action == '%')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
            }
            else
            {
                double result = 0.0;
                if (action == '*')
                    result = n1 * n2;
                else if (action == '-')
                    result = n1 - n2;
                else if (action == '+')
                    result = n1 + n2;
                Console.Write($"{n1} {action} {n2} = {result} - ");
                Console.Write(result % 2 == 0 ? "even\n" : "odd\n");
            }
            // Оператор: „+“, „-“, „*“  
            // При събиране, изваждане и умножение на конзолата трябва 
            // да се отпечатат резултата и дали той е четен или нечетен
        }
    }
}
