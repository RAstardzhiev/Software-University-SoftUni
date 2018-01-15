namespace _3.Sales_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Age", s => s.Int(nullable: true, defaultValueSql: "20"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Age");
        }
    }
}
