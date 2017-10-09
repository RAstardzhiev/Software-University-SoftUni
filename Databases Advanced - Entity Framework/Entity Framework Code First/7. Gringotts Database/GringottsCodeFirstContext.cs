namespace _7.Gringotts_Database
{
    using System.Data.Entity;
    using Models;

    public class GringottsCodeFirstContext : DbContext
    {
        public GringottsCodeFirstContext()
            : base("name=GringottsCodeFirstContext")
        {
        }

        public virtual DbSet<WizardDeposit> WizardDeposits { get; set; }
    }
}