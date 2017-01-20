using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
                Console.WriteLine("invalid number");
            else if (n == 0)
                Console.WriteLine("zero");
            else if (n == 100)
                Console.WriteLine("one hundred");
            else
            {
                if (n > 10 && n < 20)
                {
                    if (n == 11)
                        Console.WriteLine("eleven");
                    else if (n == 12)
                        Console.WriteLine("twelve");
                    else if (n == 13)
                        Console.WriteLine("thirteen");
                    else if (n == 14)
                        Console.WriteLine("fourteen");
                    else if (n == 15)
                        Console.WriteLine("fifteen");
                    else if (n == 16)
                        Console.WriteLine("sixteen");
                    else if (n == 17)
                        Console.WriteLine("seventeen");
                    else if (n == 18)
                        Console.WriteLine("eighteen");
                    else if (n == 19)
                        Console.WriteLine("nineteen");
                }
                else
                {
                    String tens = "", ones = "";
                    switch (n / 10)
                    {
                        case 1: tens = "ten"; break;
                        case 2: tens = "twenty"; break;
                        case 3: tens = "thirty"; break;
                        case 4: tens = "fourty"; break;
                        case 5: tens = "fifty"; break;
                        case 6: tens = "sixty"; break;
                        case 7: tens = "seventy"; break;
                        case 8: tens = "eighty"; break;
                        case 9: tens = "ninety"; break;
                    }
                    switch (n % 10)
                    {
                        case 1: ones = "one"; break;
                        case 2: ones = "two"; break;
                        case 3: ones = "three"; break;
                        case 4: ones = "four"; break;
                        case 5: ones = "five"; break;
                        case 6: ones = "six"; break;
                        case 7: ones = "seven"; break;
                        case 8: ones = "eight"; break;
                        case 9: ones = "nine"; break;
                    }
                    if (n % 10 == 0)
                        Console.WriteLine(tens);
                    else
                        Console.WriteLine(n < 10 ? ones : $"{tens} {ones}");
                }
            }
        }
    }
}
