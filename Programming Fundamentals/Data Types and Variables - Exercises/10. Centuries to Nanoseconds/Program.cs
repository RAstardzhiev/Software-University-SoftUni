using System;
using System.Numerics;

namespace Centuries_to_Nanoseconds
{
    public class Centuries_to_Nanoseconds
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(sbyte.MaxValue);
            //Console.WriteLine(ushort.MaxValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(ulong.MaxValue);
            //Console.WriteLine(long.MaxValue);
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            BigInteger microseconds = new BigInteger(milliseconds * 1000);
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
