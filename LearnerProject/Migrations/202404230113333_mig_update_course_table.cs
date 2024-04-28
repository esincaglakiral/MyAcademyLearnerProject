namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_course_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Date", c => c.String());
            AddColumn("dbo.Courses", "ProgramLength", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "ProgramLength");
            DropColumn("dbo.Courses", "Date");
        }
    }
}
