using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp20483.Aula2
{
    class ParteDois
    {
        public static void Executa()
        {
            // = Criando uma variável do tipo Pessoa (Objeto)
            // = new-> instanciando o objeto e chamando o construtor sem parametros '()'
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Maykon";
            pessoa1.Sobrenome = "Granemann";

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Dyego";
            pessoa2.Sobrenome = "Rauen";

            Pessoa pessoa3 = new Pessoa();
            // Chamada de metodos com parâmetros nomeados
            pessoa3.CarregaPessoa(idade:10, nome:"Maykon", sobrenome: "Granemann");
            // Chamada de metodo com parâmetro opcional
            pessoa3.CarregaPessoa("Maykon","Granemann");
            // Chamada de método com parâmetro opcional e nomeado
            pessoa3.CarregaPessoa("Maykon", idade:10);


            //Metodos.Imprimir("Maykon");
            //Metodos.Imprimir(18);
            pessoa1.Imprimir();
            
            



            //Console.WriteLine( pessoa.FormatarNomeCompleto() );

            //string nome1 = pessoa1.FormatarNomeCompleto(pessoa1);
            //string nome2 = pessoa2.FormatarNomeCompleto(pessoa2.Nome, pessoa2.Sobrenome);
            //Console.WriteLine(pessoa1.Nome); // Maykon Granemann
            //Console.WriteLine(pessoa2.Nome); // Dyego Rauen



        }
       

    }
}
