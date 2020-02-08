using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TiposVariaveis
    {

        public void Executar()
        {
            Console.WriteLine("Tipos: ");
            Console.WriteLine("Tipos por valor");
            int num1 = 10;
            int num2 = num1;
            //juntando os valores conventendo os inteiro para string;
            Console.WriteLine("Valor inteiros: "+num1 + " e " + num2 );
            num1 = 20;
            //Metodo mais atual interpolação de strings, usase $ no começo, e as variaveis entre {}
            Console.WriteLine($"Valores inteiros {num1} e {num2}");

            //Modifica ambos pois estão aprontando pro mesmo ponto da memoria
            Console.WriteLine("Tipos por referencia");
            Pessoa p1 = new Pessoa { Idade = 10, Nome = "Joao" };
            Pessoa p2 = p1;
            Console.WriteLine($"Pessoas: {p1.Nome}-{p1.Idade} ---- {p2.Nome} - {p2.Idade}");
            p1.Nome = "PEDRO";
            Console.WriteLine($"Segunda impressão Pessoas: {p1.Nome}-{p1.Idade} ---- {p2.Nome} - {p2.Idade}");
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

        }

    }
}
