namespace _20.The_Heigan_Dance
{
    using System;

    public class TheHeiganDance
    {
        public static void Main()
        {
            var player = new Player()
            {
                Position = new int[] { 7, 7 },
                Blood = 18500,
                Damage = double.Parse(Console.ReadLine()),
                IsHitByCloud = false
            };

            double bossHeiganBlood = 3000000;
            string spell = string.Empty;

            while (true)
            {
                // Check for spell influence from previous step
                if (player.IsHitByCloud)
                {
                    player.Blood -= 3500;
                    player.IsHitByCloud = false;
                }

                bossHeiganBlood -= player.Damage;

                // Check winn and loss
                if (IsGameOver(player, bossHeiganBlood, spell))
                {
                    break;
                }

                var bossAttack = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                spell = bossAttack[0];
                var hitRow = int.Parse(bossAttack[1]);
                var hitCol = int.Parse(bossAttack[2]);

                if (IsCellReached(player.Position[0], player.Position[1], hitRow, hitCol) &&
                    IsPlayerDamaged(player, hitRow, hitCol))
                {
                    switch (spell)
                    {
                        case "Cloud":
                            player.Blood -= 3500;
                            player.IsHitByCloud = true;
                            break;
                        case "Eruption":
                            player.Blood -= 6000;
                            break;
                        default:
                            break;
                    }
                }

                if (IsGameOver(player, bossHeiganBlood, spell))
                {
                    break;
                }
            }
        }

        private static bool IsGameOver(Player player, double bossHeiganBlood, string spell)
        {
            if (player.Blood <= 0 || bossHeiganBlood <= 0)
            {
                if (spell == "Cloud")
                {
                    spell = "Plague Cloud";
                }

                Console.WriteLine(bossHeiganBlood > 0
                    ? $"Heigan: {bossHeiganBlood:F2}"
                    : $"Heigan: Defeated!");

                Console.WriteLine(player.Blood > 0
                    ? $"Player: {player.Blood}"
                    : $"Player: Killed by {spell}");

                Console.WriteLine($"Final position: {player.Position[0]}, {player.Position[1]}");

                return true;
            }

            return false;
        }

        private static bool IsPlayerDamaged(Player player, int hitRow, int hitCol)
        {
            if (player.Position[0] > 0 &&
                !IsCellReached(player.Position[0] - 1, player.Position[1], hitRow, hitCol)) // Try move Up
            {
                player.Position[0]--;
                return false;
            }

            if (player.Position[1] + 1 < 15 && // Dancing area is 15 by 15 matrix
                !IsCellReached(player.Position[0], player.Position[1] + 1, hitRow, hitCol)) // Try move Right
            {
                player.Position[1]++;
                return false;
            }

            if (player.Position[0] + 1 < 15 && // Dancing area is 15 by 15 matrix
                !IsCellReached(player.Position[0] + 1, player.Position[1], hitRow, hitCol)) // Try move Down
            {
                player.Position[0]++;
                return false;
            }

            if (player.Position[1] > 0 &&
                !IsCellReached(player.Position[0], player.Position[1] - 1, hitRow, hitCol)) // Try move Left
            {
                player.Position[1]--;
                return false;
            }

            return true;
        }

        private static bool IsCellReached(int cellRow, int cellCol, int hitRow, int hitCol)
        {
            return (cellRow >= hitRow - 1) && (cellRow <= hitRow + 1) && (cellCol >= hitCol - 1) && (cellCol <= hitCol + 1);
        }
    }
}