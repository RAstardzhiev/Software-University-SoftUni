namespace _1.Local_Store.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddedQuantityAndWeight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Quantity", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Weight");
        }
    }
}
