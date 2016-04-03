namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rebuild : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "Date", c => c.DateTime(nullable: false));
        }
    }
}
