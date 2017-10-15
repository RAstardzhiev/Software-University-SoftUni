namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTags : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.TagAlbums",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Album_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Album_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagAlbums", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.TagAlbums", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TagAlbums", new[] { "Album_Id" });
            DropIndex("dbo.TagAlbums", new[] { "Tag_Id" });
            DropTable("dbo.TagAlbums");
            DropTable("dbo.Tags");
        }
    }
}
