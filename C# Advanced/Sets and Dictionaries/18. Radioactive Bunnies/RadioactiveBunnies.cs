namespace _18.Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveBunnies
    {
        public static bool isGameOver = false;
        public static bool isPlayerEscaped = false;

        public static void Main()
        {
            var layer = SetLayer();
            FillLayer(layer);
            var playerPosition = GetPlayerPosition(layer);

            // Play the game
            while (true)
            {
                var directions = Console.ReadLine().Trim().ToUpper().ToCharArray();

                for (int directionIndex = 0; directionIndex < directions.Length; directionIndex++)
                {
                    // Move the player
                    MakeAStep(layer, directions[directionIndex], playerPosition);

                    // Multiply each Bunny
                    var newBunniesPositions = new Queue<int[]>();
                    for (int i = 0; i < layer.Length; i++)
                    {
                        for (int j = 0; j < layer[i].Length; j++)
                        {
                            if (layer[i][j] == 'B')
                            {
                                MultiplyBunny(newBunniesPositions, layer, i, j);
                            }
                        }
                    }

                    InsertNewBunniesOnLayer(newBunniesPositions, layer); // Assign new Bunnies

                    if (isPlayerEscaped)
                    {
                        PrintLayer(layer);
                        Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}"); // Last position on layer
                        return;
                    }
                    else if (isGameOver)
                    {
                        PrintLayer(layer);
                        Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}"); // Dead position
                        return;
                    }
                }
            }
        }

        private static void InsertNewBunniesOnLayer(Queue<int[]> newBunniesPositions, char[][] layer)
        {
            while (newBunniesPositions.Count > 0)
            {
                layer[newBunniesPositions.Peek()[0]][newBunniesPositions.Dequeue()[1]] = 'B';
            }
        }

        private static void MultiplyBunny(Queue<int[]> newBunniesPositions, char[][] layer, int rowOfBunny, int colOfBunny)
        {
            var leftBunnyIndex = colOfBunny - 1;
            if (leftBunnyIndex >= 0 && layer[rowOfBunny][leftBunnyIndex] != 'B')
            {
                if (layer[rowOfBunny][leftBunnyIndex] == 'P')
                {
                    isGameOver = true;
                }

                newBunniesPositions.Enqueue(new int[] { rowOfBunny, leftBunnyIndex });
            }

            var rightBunnyIndex = colOfBunny + 1;
            if (rightBunnyIndex < layer[rowOfBunny].Length && layer[rowOfBunny][rightBunnyIndex] != 'B')
            {
                if (layer[rowOfBunny][rightBunnyIndex] == 'P')
                {
                    isGameOver = true;
                }

                newBunniesPositions.Enqueue(new int[] { rowOfBunny, rightBunnyIndex });
            }

            var upBunnyIndex = rowOfBunny - 1;
            if (upBunnyIndex >= 0 && layer[upBunnyIndex][colOfBunny] != 'B')
            {
                if (layer[upBunnyIndex][colOfBunny] == 'P')
                {
                    isGameOver = true;
                }

                newBunniesPositions.Enqueue(new int[] { upBunnyIndex, colOfBunny });
            }

            var downBunnyIndex = rowOfBunny + 1;
            if (downBunnyIndex < layer.Length && layer[downBunnyIndex][colOfBunny] != 'B')
            {
                if (layer[downBunnyIndex][colOfBunny] == 'P')
                {
                    isGameOver = true;
                }

                newBunniesPositions.Enqueue(new int[] { downBunnyIndex, colOfBunny });
            }


        }

        private static void MakeAStep(char[][] layer, char direction, int[] playerPosition)
        {
            layer[playerPosition[0]][playerPosition[1]] = '.'; // Delete player from previous position

            switch (direction)
            {
                case 'L':
                    if (playerPosition[1] - 1 < 0) // player will escape
                    {
                        isPlayerEscaped = true;
                        return;
                    }

                    playerPosition[1]--; // Move at Left

                    if (layer[playerPosition[0]][playerPosition[1]] == 'B') // Check for encountering a bunny
                    {
                        isGameOver = true;
                        return;
                    }

                    layer[playerPosition[0]][playerPosition[1]] = 'P';
                    break;
                case 'R':
                    if (playerPosition[1] + 1 >= layer[playerPosition[0]].Length) // player will escape
                    {
                        isPlayerEscaped = true;
                        return;
                    }

                    playerPosition[1]++; // Move at Right

                    if (layer[playerPosition[0]][playerPosition[1]] == 'B') // Check for encountering a bunny
                    {
                        isGameOver = true;
                        return;
                    }

                    layer[playerPosition[0]][playerPosition[1]] = 'P';

                    break;
                case 'U':
                    if (playerPosition[0] - 1 < 0) // player will escape
                    {
                        isPlayerEscaped = true;
                        return;
                    }

                    playerPosition[0]--; // Move at Up

                    if (layer[playerPosition[0]][playerPosition[1]] == 'B') // Check for encountering a bunny
                    {
                        isGameOver = true;
                        return;
                    }

                    layer[playerPosition[0]][playerPosition[1]] = 'P';
                    break;
                case 'D':
                    if (playerPosition[0] + 1 >= layer.Length) // player will escape
                    {
                        isPlayerEscaped = true;
                        return;
                    }

                    playerPosition[0]++; // Move at Down

                    if (layer[playerPosition[0]][playerPosition[1]] == 'B') // Check for encountering a bunny
                    {
                        isGameOver = true;
                        return;
                    }

                    layer[playerPosition[0]][playerPosition[1]] = 'P';
                    break;
                default:
                    break;
            }
        }

        private static void PrintLayer(char[][] layer)
        {
            for (int i = 0; i < layer.Length; i++)
            {
                Console.WriteLine(string.Join(string.Empty, layer[i]));
            }
        }

        private static int[] GetPlayerPosition(char[][] layer)
        {
            var playerPosition = new int[2];

            for (int i = 0; i < layer.Length; i++)
            {
                for (int j = 0; j < layer[i].Length; j++)
                {
                    if (layer[i][j] == 'P')
                    {
                        playerPosition[0] = i;
                        playerPosition[1] = j;
                        return playerPosition;
                    }
                }
            }

            return playerPosition;
        }

        private static void FillLayer(char[][] layer)
        {
            for (int i = 0; i < layer.Length; i++)
            {
                layer[i] = Console.ReadLine().Trim().ToUpper().ToCharArray().Take(layer[i].Length).ToArray();
            }
        }

        private static char[][] SetLayer()
        {
            var dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var layer = new char[dimensions[0]][].Select(arr => arr = new char[dimensions[1]]).ToArray();

            return layer;
        }
    }
}
