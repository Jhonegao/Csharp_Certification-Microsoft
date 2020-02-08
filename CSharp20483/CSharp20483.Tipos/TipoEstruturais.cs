using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TipoEstruturais
    {
        public void Executar()
        {

            Console.WriteLine("Estruturas");
            Person p1 = new Person();
            p1.idade = 18;
            p1.nome = "Paulo";
            Person p2 = p1;
            Console.WriteLine($"{p1.nome} - {p1.idade} -/- {p2.nome} - {p2.idade}");
            p1.idade = 10;
            p1.nome = "Joao";
            Console.WriteLine($"{p1.nome} - {p1.idade} -/- {p2.nome} - {p2.idade}");

        }

    }

    public struct Person
    {
        //sendo variavel nao tendo get e seters é minusculo .
        public int idade;
        public string nome;

    }
}
