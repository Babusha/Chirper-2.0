namespace Chirper_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "LastEditDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Subscriptions_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Subscriptions_Id");
            AddForeignKey("dbo.AspNetUsers", "Subscriptions_Id", "dbo.Subscriptions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Subscriptions_Id", "dbo.Subscriptions");
            DropIndex("dbo.AspNetUsers", new[] { "Subscriptions_Id" });
            DropColumn("dbo.AspNetUsers", "Subscriptions_Id");
            DropColumn("dbo.AspNetUsers", "RegistrationDate");
            DropColumn("dbo.Posts", "LastEditDate");
            DropTable("dbo.Subscriptions");
        }
    }
}
