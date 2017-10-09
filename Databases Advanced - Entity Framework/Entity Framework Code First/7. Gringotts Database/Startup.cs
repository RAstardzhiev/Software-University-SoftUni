namespace _7.Gringotts_Database
{
    using Models;

    public class Startup
    {
        public static void Main()
        {
            using (GringottsCodeFirstContext context = new GringottsCodeFirstContext())
            {
                // Creating the Database
                // context.Database.Initialize(true); // For creation of the Database

                InsertRecordsIntoTheTable(context);
            }
        }

        private static void InsertRecordsIntoTheTable(GringottsCodeFirstContext context)
        {
            var deposits = new WizardDeposit[]
            {
                new WizardDeposit("Firstfamily", 1),
                new WizardDeposit("Secondfamily", 2),
                new WizardDeposit("Thirdfamily", 3),
                new WizardDeposit("Fourthfamily", 4),
                new WizardDeposit("Fifthfamily", 5),
                new WizardDeposit("Sixthfamily", 6),
                new WizardDeposit("Seventhfamily", 7)
            };

            context.WizardDeposits.AddRange(deposits);
            context.SaveChanges();
        }
    }
}
