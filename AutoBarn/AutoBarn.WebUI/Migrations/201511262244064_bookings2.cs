namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookings2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Models", "MakeId", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "MakeId" });
            RenameColumn(table: "dbo.Models", name: "MakeId", newName: "Make_Id");
            AlterColumn("dbo.Models", "Make_Id", c => c.Int());
            CreateIndex("dbo.Models", "Make_Id");
            AddForeignKey("dbo.Models", "Make_Id", "dbo.Makes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "Make_Id", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "Make_Id" });
            AlterColumn("dbo.Models", "Make_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Models", name: "Make_Id", newName: "MakeId");
            CreateIndex("dbo.Models", "MakeId");
            AddForeignKey("dbo.Models", "MakeId", "dbo.Makes", "Id", cascadeDelete: true);
        }
    }
}
