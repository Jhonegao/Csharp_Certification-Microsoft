using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp20483.Aula2
{
    class Pessoa
    {
        public static string cpf;
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa()
        {
            //Console.WriteLine("Passando pelo construtor");
        }
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public string FormatarParaSalvar()
        {            
            string pessoaFormatada = $"{Idade};{Nome};{Sobrenome}";
            return pessoaFormatada;
        }
        public string FormatarParaSalvar(char separador)
        {
            string pessoaFormatada = $"{Idade}{separador}{Nome}{separador}{Sobrenome}";
            return pessoaFormatada;
        }

        public string FormatarNomeCompleto()
        {
            string nomeCompleto = $"{Nome} {Sobrenome}";
            return nomeCompleto;
        }
        public string FormatarNomeCompleto(Pessoa pessoa)
        {
            string nome = pessoa.Nome;
            nome = $"{pessoa.Nome} {pessoa.Sobrenome}";
            return nome;
        }
        public string FormatarNomeCompleto(string nome, string sobrenome)
        {
            this.Nome = $"{nome} {sobrenome}";
            return this.Nome;
        }

        public void CarregaPessoa(string nome, string sobrenome="Granemann", int idade=18)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"{this.Nome} {this.Sobrenome} {this.Idade}";
        }
    }
}
