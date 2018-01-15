using System;
using System.Linq;

namespace GringottsDatabaseSolutions
{
    public class Engine
    {
        public void Run()
        {
            using (GringiottsContext context = new GringiottsContext())
            {
                this.PrintUniqueFirstLetterFromNamesForWizardsWithDepositType("Troll Chest", context); // 14. First Letter
            }
        }

        private void PrintUniqueFirstLetterFromNamesForWizardsWithDepositType(string keyDepositGroup, GringiottsContext context)
            => Console.WriteLine(string.Join(Environment.NewLine, context.WizzardDeposits
                .Where(w => w.DepositGroup.Equals(keyDepositGroup, StringComparison.OrdinalIgnoreCase))
                .Select(w => w.FirstName.Substring(0, 1))
                .Distinct()
                .OrderBy(ch => ch)));
    }
}
