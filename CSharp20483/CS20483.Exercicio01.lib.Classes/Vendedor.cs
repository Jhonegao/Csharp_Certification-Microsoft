using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Exercicio01.lib.Classes
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal ComissaoTotal { get; set; }

        public Vendedor(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        //public override string ToString()
        //{
        //    foreach (var item in vendedores)
        //    {
        //        int idCount = 0;
        //        Console.WriteLine($"id: {idCount} -- Nome:{Nome} {Sobrenome} -- Comissão total atual = {ComissaoTotal}");
        //        idCount++;
        //    }
        //    return "Fim da lista de Vendedores";
        //}

        //public static List<Vendedor> vendedores = new List<Vendedor>();

    }
}
