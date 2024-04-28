namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_table_teacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Status");
        }
    }
}
