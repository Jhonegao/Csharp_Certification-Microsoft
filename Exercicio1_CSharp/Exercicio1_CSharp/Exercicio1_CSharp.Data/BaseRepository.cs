using Exercicio1_CSharp.Data.Context;
using Exercicio1_CSharp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Data
{
    //passar um tipo para essa base <nome, geramentel T de type> 
    public class BaseRepository<T> where T: BaseId
    {
        public List<T> ListAll()
        {
            List<T> listProduct = new List<T>();
            //objeto usado neste contexto e sera descartado
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                listProduct = context.Set<T>().ToList();
            }
            return listProduct;
        }
        public T GetById(int id)
        {
            T product;
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                product = context.Set<T>().Find(id);
                //outro metodo, first ou Default pois nao se sabe quantos resultados vem
                //product = context.Product.Where(p => p.Id == id).FirstOrDefault();
            }
            return product;
        }
        public string Create(T product)
        {
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                context.Set<T>().Add(product);
                context.SaveChanges();
            }
            return "Criado com sucesso!";
        }
        public string Update(T product)
        {
            using (Exercicio01_CSharpContex context = new Exercicio01_CSharpContex())
            {
                context.Entry<T>(product).State = System.Data.Entity.EntityState.Modified;

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
                var itemT = context.Set<T>().Find(id);
                context.Set<T>().Remove(itemT);
                context.SaveChanges();
            }
            return "Deletado com sucesso!!!";
        }
    }
}
