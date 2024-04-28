namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_messagetable_dropdatecolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "Tarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Tarih", c => c.DateTime());
        }
    }
}
