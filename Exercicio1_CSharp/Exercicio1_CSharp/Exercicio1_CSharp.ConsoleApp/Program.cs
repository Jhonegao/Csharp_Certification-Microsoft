using Exercicio1_CSharp.Data.Repository;
using Exercicio1_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaled EF on this app not the best way
            ProductRepository rep = new ProductRepository();

            //Product p1 = new Product { Name="Bola" , Description = "Redonda" , BarCode = "B01203040A", Price = 35.00m };
            //Product p2 = new Product { Name="Bola do Kiko" , Description = "Quadrada" , BarCode = "Q01203040G", Price = 999.00m };
            //rep.Create(p1);
            //rep.Create(p2);


            rep.Delete(2);
            foreach (var item in rep.ListAll())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
