using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp20483.Aula2
{
    static class PessoaExtensions
    {
        public static void Imprimir(this Pessoa dado)
        {
            Console.WriteLine(dado.Nome);
        }
    }
}
