using CSharp20483.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            TiposVariaveis tipos = new TiposVariaveis();
            tipos.Executar();
            TipoPorValor tpv = new TipoPorValor();
            tpv.Executar();
            Console.ReadKey();
        }
    }
}
