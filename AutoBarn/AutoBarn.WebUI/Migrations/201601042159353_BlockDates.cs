namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlockDates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlockDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlockDates");
        }
    }
}
