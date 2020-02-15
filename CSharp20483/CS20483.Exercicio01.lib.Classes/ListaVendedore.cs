using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Exercicio01.lib.Classes
{
    public class ListaVendedore
    {
        public static List<Vendedor> vendedores = new List<Vendedor>();
        public override string ToString()
        {
            foreach (var item in vendedores)
            {
                int idCount = 0;
                Console.WriteLine($"id: {idCount} -- Nome:{item.Nome} {item.Sobrenome} -- Comissão total atual = {item.ComissaoTotal}");
                idCount++;
            }
            return "Fim da lista de Vendedores";
        }
        public void AdicionarVendedor(Vendedor vendedor)
        {
            vendedores.Add(vendedor);
            Console.WriteLine("Cadastro Vend Ok");
        }

    }
}
