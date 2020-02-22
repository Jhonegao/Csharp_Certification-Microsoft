namespace Exercicio1_CSharp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableStorage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Short(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Storages", "Product_Id", "dbo.Products");
            DropIndex("dbo.Storages", new[] { "Product_Id" });
            DropTable("dbo.Storages");
        }
    }
}
