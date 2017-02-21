namespace Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ladybugs
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] bugsField = new int[size];
            PutBugsOnField(bugsField);
            Play(bugsField);
            Console.WriteLine(string.Join(" ", bugsField));
        }

        private static void Play(int[] bugsField)
        {
            string indexDirectionLength = Console.ReadLine();
            while (!indexDirectionLength.Trim().ToLower().Equals("end"))
            {
                string[] command = indexDirectionLength
                    .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (index < bugsField.Length && index >= 0 && bugsField[index] == 1)
                {
                    if (direction.ToLower().Equals("left"))
                    {
                        if (flyLength > 0)
                        {
                            // Moove Left
                            FlyLeft(bugsField, index, flyLength);
                        }
                        else
                        {
                            // Moove Right
                            FlyRight(bugsField, index, Math.Abs(flyLength));
                        }
                    }
                    else if (direction.ToLower().Equals("right"))
                    {
                        if (flyLength > 0)
                        {
                            // Moove Right
                            FlyRight(bugsField, index, flyLength);
                        }
                        else
                        {
                            // Moove Left
                            FlyLeft(bugsField, index, Math.Abs(flyLength));
                        }
                    }
                }

                indexDirectionLength = Console.ReadLine();
            }
        }

        private static void FlyRight(int[] bugsField, int index, int flyLength)
        {
            bugsField[index] = 0;

            for (int i = index + flyLength; i < bugsField.Length; i += flyLength)
            {
                if (bugsField[i] == 0)
                {
                    bugsField[i] = 1;
                    return;
                }
            }
        }

        private static void FlyLeft(int[] bugsField, int index, int flyLength)
        {
            bugsField[index] = 0;

            for (int i = index - flyLength; i >= 0; i -= flyLength)
            {
                if (bugsField[i] == 0)
                {
                    bugsField[i] = 1;
                    return;
                }
            }
        }

        private static void PutBugsOnField(int[] bugsField)
        {
            int[] places = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < bugsField.Length; i++)
            {
                if (places.Contains(i))
                {
                    bugsField[i] = 1;
                }
            }
        }
    }
}
