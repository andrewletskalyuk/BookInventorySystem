namespace LibraryInventory.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Author = c.String(nullable: false, maxLength: 255),
                        ISBN = c.String(nullable: false, maxLength: 13),
                        PublicationYear = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
        }
    }
}
