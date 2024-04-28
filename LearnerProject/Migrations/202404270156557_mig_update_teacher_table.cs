namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_teacher_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Graduate", c => c.String());
            AddColumn("dbo.Teachers", "Experience", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Experience");
            DropColumn("dbo.Teachers", "Graduate");
        }
    }
}
