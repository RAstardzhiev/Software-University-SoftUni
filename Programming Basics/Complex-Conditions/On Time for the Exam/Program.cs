using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            int examSumMinutes = examHour * 60 + examMinute;
            int arrivalSumMinutes = arrivalHour * 60 + arrivalMinute;

            if (arrivalSumMinutes > examSumMinutes)
            {
                Console.WriteLine("Late");
                if (arrivalSumMinutes - examSumMinutes < 60)
                    Console.WriteLine("{0} minutes after the start", arrivalSumMinutes - examSumMinutes);
                else Console.WriteLine("{0}:{1:00} hours after the start", (arrivalSumMinutes - examSumMinutes) / 60, (arrivalSumMinutes - examSumMinutes) % 60);
            }
            else
            {
                if (arrivalSumMinutes <= examSumMinutes && arrivalSumMinutes >= examSumMinutes - 30)
                    Console.WriteLine("On time");
                else
                    Console.WriteLine("Early");
                if (examSumMinutes - arrivalSumMinutes != 0)
                {
                    if (examSumMinutes - arrivalSumMinutes < 60)
                        Console.WriteLine("{0} minutes before the start", examSumMinutes - arrivalSumMinutes);
                    else Console.WriteLine("{0}:{1:00} hours before the start", (examSumMinutes - arrivalSumMinutes) / 60, (examSumMinutes - arrivalSumMinutes) % 60);
                }
            }
        }
    }
}
