namespace Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main(string[] args)
        {
            List<Monster> monsters = GetNames()
                .OrderBy(m => m.Name)
                .ToList();

            SetHealth(monsters);
            SetDamage(monsters);
            PrintMonsters(monsters);
        }

        private static void PrintMonsters(List<Monster> monsters)
        {
            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"{monster.Name} - {monster.Health} health, {monster.Damage:F2} damage");
            }
        }

        private static void SetDamage(List<Monster> monsters)
        {
            foreach (Monster monster in monsters)
            {
                List<double> damageData = ExtractDamageData(monster.Name);
                monster.Damage = damageData.Count > 0 ? damageData[0] : 0;
                for (int i = 1; i < damageData.Count; i++)
                {
                    monster.Damage += damageData[i];
                }

                if (monster.Name.Contains('/') || monster.Name.Contains('*'))
                {
                    DamageMultiplicationAndDivision(monster);
                }
            }
        }

        private static void DamageMultiplicationAndDivision(Monster monster)
        {
            MatchCollection matches = Regex.Matches(monster.Name, @"[/*]+");
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matches)
            {
                sb.Append(match.Value);
            }

            string operands = sb.ToString();

            foreach (char operand in operands)
            {
                switch (operand)
                {
                    case '*':
                        monster.Damage *= 2;
                        break;
                    case '/':
                        monster.Damage /= 2;
                        break;
                    default:
                        break;
                }
            }
        }

        private static List<double> ExtractDamageData(string name)
        {
            MatchCollection matches = Regex.Matches(name, @"[-+]{0,1}[0-9]+\.?[0-9]{0,}");
            List<double> damageData = new List<double>(matches.Count);
            foreach (Match match in matches)
            {
                damageData.Add(double.Parse(match.Value));
            }

            return damageData;
        }

        private static void SetHealth(List<Monster> monsters)
        {
            /*
             * The sum of the asci codes of all characters (excluding numbers (0-9), arithmetic 
             * symbols ('+', '-', '*', '/') and delimiter dot ('.')) gives a demon's total health. 
             */

            foreach (Monster monster in monsters)
            {
                string healthData = Regex.Replace(monster.Name, @"[0-9\.+-/*]+", string.Empty);
                int health = 0;
                for (int i = 0; i < healthData.Length; i++)
                {
                    health += healthData[i];
                }

                monster.Health = health;
            }
        }

        private static List<Monster> GetNames()
        {
            string[] names = Console.ReadLine()
                .Split(", \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<Monster> monsters = new List<Monster>(names.Length);

            foreach (string name in names)
            {
                monsters.Add(new Monster { Name = name });
            }

            return monsters;
        }
    }
}
