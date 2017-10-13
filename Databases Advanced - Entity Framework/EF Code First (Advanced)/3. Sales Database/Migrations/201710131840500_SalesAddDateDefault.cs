namespace _3.Sales_Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SalesAddDateDefault : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Sales", "Date", system => system.DateTime(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("Sales", "Date", system => system.String(defaultValueSql: "NULL"));
        }
    }
}
