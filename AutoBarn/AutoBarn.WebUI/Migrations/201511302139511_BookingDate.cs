namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "Date");
        }
    }
}
