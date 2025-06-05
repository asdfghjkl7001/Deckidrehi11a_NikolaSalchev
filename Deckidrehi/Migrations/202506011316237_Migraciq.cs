namespace Deckidrehi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migraciq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Cena = c.Double(nullable: false),
                        Razmer = c.Int(nullable: false),
                        Vid = c.String(),
                        tip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTypes", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductTypes", new[] { "ProductId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
