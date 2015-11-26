namespace AutoBarn.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookings1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Models", "Make_Id", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "Make_Id" });
            RenameColumn(table: "dbo.Models", name: "Make_Id", newName: "MakeId");
            AlterColumn("dbo.Models", "MakeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Models", "MakeId");
            AddForeignKey("dbo.Models", "MakeId", "dbo.Makes", "Id", cascadeDelete: true);
            DropColumn("dbo.Models", "ModelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "ModelId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Models", "MakeId", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "MakeId" });
            AlterColumn("dbo.Models", "MakeId", c => c.Int());
            RenameColumn(table: "dbo.Models", name: "MakeId", newName: "Make_Id");
            CreateIndex("dbo.Models", "Make_Id");
            AddForeignKey("dbo.Models", "Make_Id", "dbo.Makes", "Id");
        }
    }
}
