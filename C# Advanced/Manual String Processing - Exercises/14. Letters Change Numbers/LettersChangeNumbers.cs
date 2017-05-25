namespace _14.Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var pcs = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0.0M;

            foreach (var piece in pcs)
            {
                var test = piece.Substring(1, piece.Length - 1);
                result += CalculateCurrentPiece(piece[0], piece[piece.Length - 1], decimal.Parse(piece.Substring(1, piece.Length - 2)));
            }

            Console.WriteLine($"{result:F2}");
        }

        private static decimal CalculateCurrentPiece(char firstLetter, char lastLetter, decimal number)
        {
            number = ProcessFirstLetter(firstLetter, number);
            return ProcessLastLetter(lastLetter, number);
        }

        private static decimal ProcessLastLetter(char letter, decimal number)
        {
            if (char.IsUpper(letter))
            {
                return number - (letter - 'A' + 1);
            }
            else if (char.IsLower(letter))
            {
                return number + (letter - 'a' + 1);
            }
            else
            {
                return number;
            }
        }

        private static decimal ProcessFirstLetter(char letter, decimal number)
        {
            if (char.IsUpper(letter))
            {
                return number * 1.0M / (letter - 'A' + 1);
            }
            else if (char.IsLower(letter))
            {
                return number * 1.0M * (letter - 'a' + 1);
            }
            else
            {
                return number;
            }
        }
    }
}
