using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TipoPorValor
    {
        public void Executar()
        {
            Console.WriteLine("Tipos por valor");
            Console.WriteLine("Tipo Integrais");
            int num1 = 10;
            Console.WriteLine($"Inteiros 32 {Int32.MinValue} - {Int32.MaxValue}");
        }
    }
}
