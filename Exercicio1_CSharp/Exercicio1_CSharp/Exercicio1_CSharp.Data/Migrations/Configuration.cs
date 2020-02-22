namespace Exercicio1_CSharp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exercicio1_CSharp.Data.Context.Exercicio01_CSharpContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exercicio1_CSharp.Data.Context.Exercicio01_CSharpContex context)
        {
            
        }
    }
}
