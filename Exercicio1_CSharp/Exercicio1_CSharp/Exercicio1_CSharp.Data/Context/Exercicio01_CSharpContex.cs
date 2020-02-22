using Exercicio1_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Data.Context
{
    public class Exercicio01_CSharpContex : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public Exercicio01_CSharpContex():base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\67285\Documents\csharp\Csharp_Certification-Microsoft\Exercicio1_CSharp\Exercicio1_CSharp\Exercicio1_CSharp.Data\Database\DBCSharp.mdf;Integrated Security=True")
        {

        }
    }
}
