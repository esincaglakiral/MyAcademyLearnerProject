namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_table_testimonial_about_classroom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Classrooms", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Testimonials", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testimonials", "Status");
            DropColumn("dbo.Classrooms", "Status");
            DropColumn("dbo.Abouts", "Status");
        }
    }
}
