namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAlbumsAndPictures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        BackgroundColor = c.String(nullable: false, maxLength: 25),
                        IsPublic = c.Boolean(nullable: false),
                        PhotographerOwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Photographers", t => t.PhotographerOwnerId, cascadeDelete: true)
                .Index(t => t.PhotographerOwnerId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Caption = c.String(nullable: false, maxLength: 50),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PictureAlbums",
                c => new
                    {
                        Picture_Id = c.Int(nullable: false),
                        Album_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Picture_Id, t.Album_Id })
                .ForeignKey("dbo.Pictures", t => t.Picture_Id, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_Id, cascadeDelete: true)
                .Index(t => t.Picture_Id)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PictureAlbums", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.PictureAlbums", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Albums", "PhotographerOwnerId", "dbo.Photographers");
            DropIndex("dbo.PictureAlbums", new[] { "Album_Id" });
            DropIndex("dbo.PictureAlbums", new[] { "Picture_Id" });
            DropIndex("dbo.Albums", new[] { "PhotographerOwnerId" });
            DropTable("dbo.PictureAlbums");
            DropTable("dbo.Pictures");
            DropTable("dbo.Albums");
        }
    }
}
