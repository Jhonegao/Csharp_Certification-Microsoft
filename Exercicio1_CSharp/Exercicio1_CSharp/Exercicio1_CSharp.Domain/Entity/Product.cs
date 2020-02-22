using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_CSharp.Domain.Entities
{
    public class Product : BaseId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string BarCode { get; set; }

        public override string ToString()
        {
            return $"-----\nId: {this.Id}\nNome: {this.Name}\nDescricao: {Description}\nPreço: {Price}\nCódigo: {BarCode}";
        }
    }
}
