namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingNotes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "Notes");
        }
    }
}
