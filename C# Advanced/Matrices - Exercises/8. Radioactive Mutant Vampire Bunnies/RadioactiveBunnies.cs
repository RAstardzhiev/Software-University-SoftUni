namespace _8.Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RadioactiveBunnies
    {
        public static void Main()
        {
            int[] playerPosition;
            var bunnies = InitializeMatrix(out playerPosition);
            PlayTheGame(bunnies, playerPosition);
        }

        private static void PlayTheGame(bool[][] bunnies, int[] playerPosition)
        {
            while (true)
            {
                var playerSpepDirections = Console.ReadLine().ToCharArray();
                var isPlayerEscaped = false;

                foreach (var stepDirection in playerSpepDirections)
                {
                    isPlayerEscaped = IsPlayerEscaped(bunnies, playerPosition, stepDirection);
                    MultiplyBunnies(bunnies);

                    if (isPlayerEscaped)
                    {
                        PrintMatrix(bunnies);
                        Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                        return;
                    }

                    if (bunnies[playerPosition[0]][playerPosition[1]])
                    {
                        PrintMatrix(bunnies);
                        Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}");
                        return;
                    }
                }
            }
        }

        private static void PrintMatrix(bool[][] bunnies)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < bunnies.Length; i++)
            {
                for (int j = 0; j < bunnies[i].Length; j++)
                {
                    sb.Append(bunnies[i][j] ? 'B' : '.');
                }

                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static void MultiplyBunnies(bool[][] bunnies)
        {
            var newBunnies = new Stack<int[]>();

            for (int i = 0; i < bunnies.Length; i++)
            {
                for (int j = 0; j < bunnies[i].Length; j++)
                {
                    if (bunnies[i][j])
                    {
                        newBunnies.Push(new int[] { i + 1, j });
                        newBunnies.Push(new int[] { i - 1, j });
                        newBunnies.Push(new int[] { i, j + 1 });
                        newBunnies.Push(new int[] { i, j - 1 });
                    }
                }
            }

            while (newBunnies.Count > 0)
            {
                var currentBunny = newBunnies.Pop();
                if (IsInsideTheLayer(currentBunny, bunnies))
                {
                    bunnies[currentBunny[0]][currentBunny[1]] = true;
                }
            }
        }

        private static bool IsInsideTheLayer(int[] cell, bool[][] matrix)
        {
            return cell[0] >= 0 && cell[0] < matrix.Length && cell[1] >= 0 && cell[1] < matrix[0].Length;
        }

        private static bool IsPlayerEscaped(bool[][] bunnies, int[] playerPosition, char stepDirection)
        {
            switch (stepDirection)
            {
                case 'U': // Step Up
                    playerPosition[0]--;

                    if (!IsInsideTheLayer(playerPosition, bunnies))
                    {
                        playerPosition[0]++;
                        return true;
                    }

                    break;
                case 'D': // Step Down
                    playerPosition[0]++;

                    if (!IsInsideTheLayer(playerPosition, bunnies))
                    {
                        playerPosition[0]--;
                        return true;
                    }

                    break;
                case 'L': // Step Left
                    playerPosition[1]--;

                    if (!IsInsideTheLayer(playerPosition, bunnies))
                    {
                        playerPosition[1]++;
                        return true;
                    }

                    break;
                case 'R': // Step Right
                    playerPosition[1]++;

                    if (!IsInsideTheLayer(playerPosition, bunnies))
                    {
                        playerPosition[1]--;
                        return true;
                    }

                    break;
                default:
                    break;
            }

            return false;
        }

        private static bool[][] InitializeMatrix(out int[] playerPosition)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            playerPosition = new int[] { 0, 0 };
            var bunnies = new bool[dimensions[0]][];

            for (int i = 0; i < bunnies.Length; i++)
            {
                var input = Console.ReadLine();
                bunnies[i] = new bool[input.Length];

                for (int j = 0; j < bunnies[i].Length; j++)
                {
                    if (input[j] == 'B')
                    {
                        bunnies[i][j] = true;
                    }
                    else if (input[j] == 'P')
                    {
                        playerPosition[0] = i;
                        playerPosition[1] = j;
                    }
                }
            }

            return bunnies;
        }
    }
}
