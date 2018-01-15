namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPhotgrapher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photographers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 16),
                        Email = c.String(nullable: false, maxLength: 50),
                        RegisterDate = c.DateTime(defaultValueSql: "GETDATE()"),
                        BirthDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Photographers");
        }
    }
}
