namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_remove_relation_classroom_and_course : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Classroom_ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.Courses", new[] { "Classroom_ClassroomId" });
            DropColumn("dbo.Courses", "ClassroomyId");
            DropColumn("dbo.Courses", "Classroom_ClassroomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Classroom_ClassroomId", c => c.Int());
            AddColumn("dbo.Courses", "ClassroomyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Classroom_ClassroomId");
            AddForeignKey("dbo.Courses", "Classroom_ClassroomId", "dbo.Classrooms", "ClassroomId");
        }
    }
}
