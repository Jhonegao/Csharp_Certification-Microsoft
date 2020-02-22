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
            //objeto usado neste contexto e sera descartado
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                listProduct = context.Product.ToList();
            }
            return listProduct;
        }
        public Product GetById(int id)
        {
            Product product = new Product();
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                product = context.Product.Find(id);
                //outro metodo, first ou Default pois nao se sabe quantos resultados vem
                //product = context.Product.Where(p => p.Id == id).FirstOrDefault();
            }
            return product;
        }
        public string Create(Product product)
        {
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                context.Product.Add(product);
                context.SaveChanges();
            }
            return "Criado com sucesso!";
        }
        public string Update(Product product)
        {
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                context.Entry<Product>(product).State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();
            }
            return "Alterado com sucesso!!";
        }
        public string Delete(int id)
        {
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                //var product = GetById(id);
                //context.Entry<Product>(product).State = System.Data.Entity.EntityState.Deleted;
                var pdb = context.Product.Find(id);
                context.Product.Remove(pdb);
                context.SaveChanges();
            }
            return "Deletado com sucesso!!!";
        }

    }
}
