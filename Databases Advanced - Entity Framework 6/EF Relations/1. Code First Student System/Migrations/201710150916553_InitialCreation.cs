namespace _1.Code_First_Student_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        EndDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContentPath = c.String(nullable: false, maxLength: 100),
                        ContentType = c.String(nullable: false, maxLength: 25),
                        SubmissionDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        StudentId = c.Int(nullable: false),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.ContentPath, unique: true)
                .Index(t => t.StudentId)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(maxLength: 20),
                        RegistrationDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        Birthday = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Name, t.PhoneNumber }, unique: true, name: "IX_Name_phoneNumber");
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ResourceType = c.String(nullable: false, maxLength: 25),
                        Url = c.String(nullable: false, maxLength: 100),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Url, unique: true)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resources", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Homework", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Homework", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.Resources", new[] { "Course_Id" });
            DropIndex("dbo.Resources", new[] { "Url" });
            DropIndex("dbo.Students", "IX_Name_phoneNumber");
            DropIndex("dbo.Homework", new[] { "Course_Id" });
            DropIndex("dbo.Homework", new[] { "StudentId" });
            DropIndex("dbo.Homework", new[] { "ContentPath" });
            DropIndex("dbo.Courses", new[] { "Name" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Resources");
            DropTable("dbo.Students");
            DropTable("dbo.Homework");
            DropTable("dbo.Courses");
        }
    }
}
