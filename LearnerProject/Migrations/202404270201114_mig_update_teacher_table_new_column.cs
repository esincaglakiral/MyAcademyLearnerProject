namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_teacher_table_new_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "ExperienceYear", c => c.String());
            AddColumn("dbo.Teachers", "Skill", c => c.String());
            AddColumn("dbo.Teachers", "Certificate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Certificate");
            DropColumn("dbo.Teachers", "Skill");
            DropColumn("dbo.Teachers", "ExperienceYear");
        }
    }
}
