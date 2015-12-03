namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreBookings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Bookings", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Contacts", "Model_Id", "dbo.Models");
            DropIndex("dbo.Bookings", new[] { "Model_Id" });
            DropIndex("dbo.Bookings", new[] { "Service_Id" });
            DropIndex("dbo.Contacts", new[] { "Model_Id" });
            RenameColumn(table: "dbo.Bookings", name: "Model_Id", newName: "ModelId");
            RenameColumn(table: "dbo.Bookings", name: "Service_Id", newName: "ServiceId");
            RenameColumn(table: "dbo.Contacts", name: "Model_Id", newName: "ModelId");
            AlterColumn("dbo.Bookings", "ModelId", c => c.Int(nullable: false));
            AlterColumn("dbo.Bookings", "ServiceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "ModelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bookings", "ModelId");
            CreateIndex("dbo.Bookings", "ServiceId");
            CreateIndex("dbo.Contacts", "ModelId");
            AddForeignKey("dbo.Bookings", "ModelId", "dbo.Models", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bookings", "ServiceId", "dbo.Services", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Contacts", "ModelId", "dbo.Models", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Bookings", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Bookings", "ModelId", "dbo.Models");
            DropIndex("dbo.Contacts", new[] { "ModelId" });
            DropIndex("dbo.Bookings", new[] { "ServiceId" });
            DropIndex("dbo.Bookings", new[] { "ModelId" });
            AlterColumn("dbo.Contacts", "ModelId", c => c.Int());
            AlterColumn("dbo.Bookings", "ServiceId", c => c.Int());
            AlterColumn("dbo.Bookings", "ModelId", c => c.Int());
            RenameColumn(table: "dbo.Contacts", name: "ModelId", newName: "Model_Id");
            RenameColumn(table: "dbo.Bookings", name: "ServiceId", newName: "Service_Id");
            RenameColumn(table: "dbo.Bookings", name: "ModelId", newName: "Model_Id");
            CreateIndex("dbo.Contacts", "Model_Id");
            CreateIndex("dbo.Bookings", "Service_Id");
            CreateIndex("dbo.Bookings", "Model_Id");
            AddForeignKey("dbo.Contacts", "Model_Id", "dbo.Models", "Id");
            AddForeignKey("dbo.Bookings", "Service_Id", "dbo.Services", "Id");
            AddForeignKey("dbo.Bookings", "Model_Id", "dbo.Models", "Id");
        }
    }
}
