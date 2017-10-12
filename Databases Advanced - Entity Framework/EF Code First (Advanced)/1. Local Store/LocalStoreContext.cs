namespace _1.Local_Store
{
    using System.Data.Entity;
    using Modedls;

    public class LocalStoreContext : DbContext
    {
        public LocalStoreContext()
            : base("name=LocalStoreContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}