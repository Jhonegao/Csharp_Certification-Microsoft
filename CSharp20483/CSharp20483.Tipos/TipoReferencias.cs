using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TipoReferencias
    {
        public void Executar()
        {
            Console.WriteLine("Referencia Classe");
            PersonClass p1 = new PersonClass();
            Console.WriteLine($"Classe Pessoa: {p1}");
        }

    }

    //nao é permetido duas classes com o mesmo nome no mesmo namespace
    public class PersonClass
    {
        //sendo variavel nao tendo get e seters é minusculo .
        //public int idade;
        //public string nome;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"{this.Nome}-{this.Idade}";
        }

    }

}

