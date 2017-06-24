namespace _02.Monopoly
{
    using System;
    using System.Linq;

    public class Monopoly
    {
        private static int startMoney = 50;

        public static void Main()
        {
            var player = new Player
            {
                Money = startMoney
            };

            var matrix = GetMatrix();

            PlayMonipoly(matrix, player);
        }

        private static void PlayMonipoly(char[][] matrix, Player player)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    MakeAStep(player, matrix, i, j);
                }

                i++;

                if (i >= matrix.Length)
                {
                    break;
                }

                for (int j = matrix[i].Length - 1; j >= 0; j--)
                {
                    MakeAStep(player, matrix, i, j);
                }
            }

            Console.WriteLine($"Turns {player.Turns}");
            Console.WriteLine($"Money {player.Money}");
        }

        private static void MakeAStep(Player player, char[][] matrix, int i, int j)
        {
            switch (matrix[i][j])
            {
                case 'H':
                    player.Hotels++;
                    Console.WriteLine($"Bought a hotel for {player.Money}. Total hotels: {player.Hotels}.");
                    player.Money = 0;
                    break;
                case 'J':
                    Console.WriteLine($"Gone to jail at turn {player.Turns}.");
                    player.Money += player.Hotels * 20;
                    player.Turns += 2;
                    break;
                case 'F':
                    break;
                case 'S':
                    var neededMoney = (i + 1) * (j + 1);

                    if (neededMoney >= player.Money)
                    {
                        Console.WriteLine($"Spent {player.Money} money at the shop.");
                        player.Money = 0;
                    }
                    else
                    {
                        player.Money -= neededMoney;
                        Console.WriteLine($"Spent {neededMoney} money at the shop.");
                    }
                    break;
                default:
                    break;
            }

            player.Turns++;
            player.Money += player.Hotels * 10;
        }

        private static char[][] GetMatrix()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new char[dimensions[0]][]
                .Select(row => row = Console.ReadLine().ToUpper().ToCharArray())
                .ToArray();
        }
    }
}
