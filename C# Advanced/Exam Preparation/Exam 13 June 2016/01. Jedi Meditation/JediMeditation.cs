namespace _01.Jedi_Meditation
{
    using System;
    using System.Text;

    public class JediMeditation
    {
        public static bool isThereYoda = false;

        public static void Main()
        {
            var linesOfInput = int.Parse(Console.ReadLine());
            var masterJedis = new StringBuilder();
            var knightJedis = new StringBuilder();
            var padawanJedis = new StringBuilder();
            var toshkoSlav = new StringBuilder();

            for (int i = 0; i < linesOfInput; i++)
            {
                var input = Console.ReadLine().Split(' ');
                PutJedisOnTheirPlaces(input, masterJedis, knightJedis, padawanJedis, toshkoSlav);
            }
                Console.WriteLine(isThereYoda 
                    ? masterJedis.Append(knightJedis).Append(toshkoSlav).Append(padawanJedis)
                    : toshkoSlav.Append(masterJedis).Append(knightJedis).Append(padawanJedis));
        }

        private static void PutJedisOnTheirPlaces(string[] input, StringBuilder masterJedis, StringBuilder knightJedis, StringBuilder padawanJedis, StringBuilder toshkoSlav)
        {
            foreach (var jedi in input)
            {
                switch (jedi[0])
                {
                    case 'm':
                        masterJedis.Append($"{jedi} ");
                        break;
                    case 'k':
                        knightJedis.Append($"{jedi} ");
                        break;
                    case 'p':
                        padawanJedis.Append($"{jedi} ");
                        break;
                    case 't':
                    case 's':
                        toshkoSlav.Append($"{jedi} ");
                        break;
                    case 'y':
                        isThereYoda = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
