using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp20483.Aula2
{
    class ParteUm
    {
        public static void Executa()
        {

            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("Maykon");
            Pessoa.cpf = "10";

            pessoa.Idade = 18;
            pessoa.Nome = "Maykon";
            pessoa.Sobrenome = "Granemann";
            string pessoaRetornada = pessoa.FormatarParaSalvar();
            string pessoaRetornadaTraco = pessoa.FormatarParaSalvar('-');
            Console.WriteLine(pessoaRetornada);
            Console.WriteLine(pessoaRetornadaTraco);
            Console.Read();
        }
    }
}
