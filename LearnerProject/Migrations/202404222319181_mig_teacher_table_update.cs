namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_teacher_table_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "ImageUrl");
        }
    }
}
