using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class OutrosTipos : Aulas
    {

        public void Executar()
        {
            Console.WriteLine("Outros tipos por valor");
            Console.WriteLine("Boolean");
            bool maiorIdade = true;
            bool menorIdade = true;
            byte n1 = 10;
            byte n2 = 2;
            bool par = (n1 % n2 == 0);
            Console.WriteLine($"O resultado do modulo de {n1} e {2} é {(n1 % n2)}");
            Console.WriteLine($"Zero é {par}");

        }
    }
}
