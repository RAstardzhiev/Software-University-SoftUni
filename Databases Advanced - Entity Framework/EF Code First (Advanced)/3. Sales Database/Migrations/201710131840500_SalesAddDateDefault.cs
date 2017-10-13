namespace _3.Sales_Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SalesAddDateDefault : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Sales", "Date", s => s.String(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("Sales", "Date", s => s.String(defaultValueSql: "NULL"));
        }
    }
}
