namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_course_table_addcolumn_quota : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Quota", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Quota");
        }
    }
}
