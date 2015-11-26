namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model_Id = c.Int(),
                        Service_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.Model_Id)
                .ForeignKey("dbo.Services", t => t.Service_Id)
                .Index(t => t.Model_Id)
                .Index(t => t.Service_Id);
            
            AddColumn("dbo.Contacts", "Registration", c => c.String());
            AddColumn("dbo.Contacts", "Model_Id", c => c.Int());
            AddColumn("dbo.Contacts", "Service_Id", c => c.Int());
            AddColumn("dbo.Models", "ModelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contacts", "Model_Id");
            CreateIndex("dbo.Contacts", "Service_Id");
            AddForeignKey("dbo.Contacts", "Model_Id", "dbo.Models", "Id");
            AddForeignKey("dbo.Contacts", "Service_Id", "dbo.Services", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Contacts", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Bookings", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Bookings", "Model_Id", "dbo.Models");
            DropIndex("dbo.Contacts", new[] { "Service_Id" });
            DropIndex("dbo.Contacts", new[] { "Model_Id" });
            DropIndex("dbo.Bookings", new[] { "Service_Id" });
            DropIndex("dbo.Bookings", new[] { "Model_Id" });
            DropColumn("dbo.Models", "ModelId");
            DropColumn("dbo.Contacts", "Service_Id");
            DropColumn("dbo.Contacts", "Model_Id");
            DropColumn("dbo.Contacts", "Registration");
            DropTable("dbo.Bookings");
        }
    }
}
