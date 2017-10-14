namespace _3.Sales_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", s => s.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
