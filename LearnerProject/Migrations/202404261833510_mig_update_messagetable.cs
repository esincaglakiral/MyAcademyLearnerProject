namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_messagetable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Tarih", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Tarih", c => c.DateTime(nullable: false));
        }
    }
}
