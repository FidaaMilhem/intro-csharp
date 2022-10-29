namespace MiniCollage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Points = c.Int(nullable: false),
                        Lecturer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lecturers", t => t.Lecturer_Id)
                .Index(t => t.Lecturer_Id);
            
            CreateTable(
                "dbo.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Room = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student = c.String(),
                        Course = c.String(),
                        Status = c.String(),
                        Grade = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        FamilyName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.Lecturers");
            DropIndex("dbo.RegCourses", new[] { "Student_Id" });
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.RegCourses");
            DropTable("dbo.Lecturers");
            DropTable("dbo.Courses");
        }
    }
}
