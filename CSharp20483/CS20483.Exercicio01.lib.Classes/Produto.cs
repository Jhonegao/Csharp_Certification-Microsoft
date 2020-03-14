using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Exercicio01.lib.Classes
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Produto(string nome, decimal preco, int quantidade) {

            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }
        public override bool Equals(Object obj)
        {
            Produto obj2 = (Produto)obj;
            return this.Nome == obj2.Nome;
        }
    }
}
