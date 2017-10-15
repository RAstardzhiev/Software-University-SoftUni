namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumsCanHaveManyPhotographers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhotographerAlbums",
                c => new
                    {
                        Photographer_Id = c.Int(nullable: false),
                        Album_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Photographer_Id, t.Album_Id })
                .ForeignKey("dbo.Photographers", t => t.Photographer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_Id, cascadeDelete: true)
                .Index(t => t.Photographer_Id)
                .Index(t => t.Album_Id);

            Sql(@"
                INSERT INTO PhotographerAlbums
                       SELECT PhotographerId,
                              AlbumId
                       FROM
                       (
                           SELECT Photographers.Id AS PhotographerId,
                                  Albums.Id AS AlbumId
                           FROM Photographers
                                JOIN Albums ON Photographers.Id = Albums.PhotographerOwnerId
                       ) AS ids;
                ");

            DropForeignKey("dbo.Albums", "PhotographerOwnerId", "dbo.Photographers");
            DropIndex("dbo.Albums", new[] { "PhotographerOwnerId" });
            DropColumn("dbo.Albums", "PhotographerOwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "PhotographerOwnerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.PhotographerAlbums", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.PhotographerAlbums", "Photographer_Id", "dbo.Photographers");
            DropIndex("dbo.PhotographerAlbums", new[] { "Album_Id" });
            DropIndex("dbo.PhotographerAlbums", new[] { "Photographer_Id" });
            DropTable("dbo.PhotographerAlbums");
            CreateIndex("dbo.Albums", "PhotographerOwnerId");
            AddForeignKey("dbo.Albums", "PhotographerOwnerId", "dbo.Photographers", "Id", cascadeDelete: true);
        }
    }
}
