namespace Exercicio1_CSharp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LegalPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        IE = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NaturalPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        Age = c.Byte(nullable: false),
                        CPF = c.String(),
                        RG = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NaturalPersons");
            DropTable("dbo.LegalPersons");
        }
    }
}
