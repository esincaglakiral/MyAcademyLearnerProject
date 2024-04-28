namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_message_table_datecolumn_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Tarih", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "Tarih");
        }
    }
}
