namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreBookings1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "Contact_Id", c => c.Int());
            CreateIndex("dbo.Bookings", "Contact_Id");
            AddForeignKey("dbo.Bookings", "Contact_Id", "dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.Bookings", new[] { "Contact_Id" });
            DropColumn("dbo.Bookings", "Contact_Id");
        }
    }
}
