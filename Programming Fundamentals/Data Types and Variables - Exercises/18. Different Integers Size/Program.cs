using System;

namespace Different_Integers_Size
{
    public class Different_Integers_Size
    {
        public static void Main(string[] args)
        {
            String inputNumber = Console.ReadLine();
            String output = "";
            try
            {
                sbyte n = sbyte.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* sbyte" : $"{inputNumber} can fit in:\n* sbyte";
            }
            catch (Exception)
            {
            }
            try
            {
                byte n = Byte.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* byte" : $"{inputNumber} can fit in:\n* byte";
            }
            catch (Exception)
            {
            }
            try
            {
                short n = short.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* short" : $"{inputNumber} can fit in:\n* short";
            }
            catch (Exception)
            {
            }
            try
            {
                ushort n = ushort.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* ushort" : $"{inputNumber} can fit in:\n* ushort";
            }
            catch (Exception)
            {
            }
            try
            {
                int n = int.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* int" : $"{inputNumber} can fit in:\n* int";
            }
            catch (Exception)
            {
            }
            try
            {
                uint n = uint.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* uint" : $"{inputNumber} can fit in:\n* uint";
            }
            catch (Exception)
            {
            }
            try
            {
                long n = long.Parse(inputNumber);
                output += (output.Contains("can fit in:")) ? "\n* long" : $"{inputNumber} can fit in:\n* long";
            }
            catch (Exception)
            {
            }
            //Console.WriteLine(output == null ? "null" : output);
            Console.WriteLine(output.Contains("can fit in:") ? output : $"{inputNumber} can't fit in any type");
        }
    }
}
