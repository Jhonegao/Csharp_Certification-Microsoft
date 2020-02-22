using Exercicio1_CSharp.Data.Context;
using Exercicio1_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Data.Repository
{
    public class ProductRepository
    {
        
        public List<Product> ListAll()
        {
            List<Product> listProduct = new List<Product>();
            Exercicio01_CSharpContex context = new Exercicio01_CSharpContex();
            listProduct = context.Product.ToList();
            context.Dispose();
            return listProduct;
        }
        public Product GetById(int id)
        {
            Product product = new Product();
            return product;
        }
        public string Create(Product product)
        {
            return "Criado com sucesso!";
        }
        public string Update(Product product)
        {
            return "Alterado com sucesso!!";
        }
        public string Delete(int id)
        {
            return "Deletado com sucesso!!!";
        }

    }
}
