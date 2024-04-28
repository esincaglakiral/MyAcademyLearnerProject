namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_course_table_statuscolumn_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Status");
        }
    }
}
