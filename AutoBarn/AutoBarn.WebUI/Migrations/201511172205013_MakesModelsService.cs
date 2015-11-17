namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakesModelsService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DealerPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Model_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Models", t => t.Model_Id)
                .Index(t => t.Model_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "Model_Id", "dbo.Models");
            DropIndex("dbo.Services", new[] { "Model_Id" });
            DropTable("dbo.Services");
        }
    }
}
