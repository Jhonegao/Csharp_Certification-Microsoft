using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Exercicio01.lib.Classes
{
    public class EstoqueProduto
    {
        public static List<Produto> produtos = new List<Produto>();


        public override string ToString()
        {
            foreach (var item in produtos)
            {
                int idCount = 0;
                Console.WriteLine($"ID: {idCount} - Nome do produto: {item.Nome}, Preço:{item.Preco}, Quantidade:{item.Quantidade}");
                idCount++;
            }
            return "Fim da lista de produtos";
        }

        public void AdicionarEstoque(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("Cadastro ProdOk");
        }
    }
}
