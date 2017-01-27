namespace Draw_a_Filled_Square
{
    using System;

    public class DrawFilledSquare
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            DrowSquare(rows);
        }

        public static void DrowSquare(int rows)
        {
            PrintLine(rows * 2);
            for (int j = 0; j < rows - 2; j++)
            {
                Console.Write('-');
                for (int i = 0; i < rows - 1; i++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }

            PrintLine(rows * 2);
        }

        public static void PrintLine(int length)
        {
            Console.WriteLine(new string('-', length));
        }
    }
}
