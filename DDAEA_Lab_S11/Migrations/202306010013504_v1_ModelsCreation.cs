namespace DDAEA_Lab_S11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1_ModelsCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerFirstName = c.String(),
                        CustomerLastName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        DetailID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.InvoiceID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Details", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            DropIndex("dbo.Details", new[] { "InvoiceID" });
            DropIndex("dbo.Details", new[] { "ProductID" });
            DropTable("dbo.Products");
            DropTable("dbo.Invoices");
            DropTable("dbo.Details");
            DropTable("dbo.Customers");
        }
    }
}
