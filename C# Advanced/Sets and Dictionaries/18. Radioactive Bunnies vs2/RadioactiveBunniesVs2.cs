namespace _18.Radioactive_Bunnies_vs2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveBunniesVs2
    {

        public static void Main()
        {
            var playerPosition = new int[2];
            var layer = InitializeLayer(playerPosition);

            // Play the Game
            while (true)
            {
                var directions = Console.ReadLine().ToUpper().ToCharArray();

                foreach (var direction in directions)
                {
                    // Player makes a step
                    switch (direction)
                    {
                        case 'L':
                            if (playerPosition[1] - 1 < 0)
                            {
                                MultiplyBunnies(layer);
                                PrintLayer(layer);
                                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                                return;
                            }

                            playerPosition[1]--;
                            break;
                        case 'R':
                            if (playerPosition[1] + 1 >= layer[playerPosition[0]].Length)
                            {
                                MultiplyBunnies(layer);
                                PrintLayer(layer);
                                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                                return;
                            }

                            playerPosition[1]++;
                            break;
                        case 'U':
                            if (playerPosition[0] - 1 < 0)
                            {
                                MultiplyBunnies(layer);
                                PrintLayer(layer);
                                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                                return;
                            }

                            playerPosition[0]--;
                            break;
                        case 'D':
                            if (playerPosition[0] + 1 >= layer.Length)
                            {
                                MultiplyBunnies(layer);
                                PrintLayer(layer);
                                Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                                return;
                            }

                            playerPosition[0]++;
                            break;
                        default:
                            break;
                    }

                    // Bunnies Multiplication
                    MultiplyBunnies(layer);

                    // Check for Loss
                    if (layer[playerPosition[0]][playerPosition[1]] == 'B')
                    {
                        PrintLayer(layer);
                        Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}");
                        return;
                    }
                }
            }
        }

        private static void PrintLayer(char[][] layer)
        {
            for (int i = 0; i < layer.Length; i++)
            {
                Console.WriteLine(string.Join(string.Empty, layer[i]));
            }
        }

        private static void MultiplyBunnies(char[][] layer)
        {
            var newBunnies = new Queue<int[]>();

            for (int i = 0; i < layer.Length; i++)
            {
                for (int j = 0; j < layer[i].Length; j++)
                {
                    if (layer[i][j] == 'B')
                    {
                        var upBunny = i - 1;
                        var downBunny = i + 1;
                        var leftBunny = j - 1;
                        var rightBunny = j + 1;

                        if (upBunny >= 0 && layer[upBunny][j] != 'B')
                        { 
                            newBunnies.Enqueue(new int[] { upBunny, j });
                        }

                        if (downBunny < layer.Length && layer[downBunny][j] != 'B')
                        { 
                            newBunnies.Enqueue(new int[] { downBunny, j });
                        }

                        if (leftBunny >= 0 && layer[i][leftBunny] != 'B')
                        {
                            newBunnies.Enqueue(new int[] { i, leftBunny });
                        }

                        if (rightBunny < layer[i].Length && layer[i][rightBunny] != 'B')
                        {
                            newBunnies.Enqueue(new int[] { i, rightBunny });
                        }
                    }
                }
            }

            while (newBunnies.Count > 0)
            {
                layer[newBunnies.Peek()[0]][newBunnies.Dequeue()[1]] = 'B';
            }
        }

        private static char[][] InitializeLayer(int[] playerPosition)
        {
            var rowsCols = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[rowsCols[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var input = Console.ReadLine().ToUpper().ToCharArray();

                if (input.Contains('P'))
                {
                    playerPosition[0] = i;
                    playerPosition[1] = Array.IndexOf(input, 'P');
                    input[playerPosition[1]] = '.';
                }

                matrix[i] = input;
            }

            return matrix;
        }
    }
}
