namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_socialmedia_table_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaUrl = c.String(),
                        Icon = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
