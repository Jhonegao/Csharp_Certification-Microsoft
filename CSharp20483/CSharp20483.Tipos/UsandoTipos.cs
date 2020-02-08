using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class UsandoTipos
    {
        public void Execute()
        {
            Console.WriteLine("Conversao de tipos valor");
            byte n1 = 10;
            short n2 = 10;
            //Var tipo é definido durante a atribuição, é utilizado no foreach por exemplo, pois ai o compiler define
            //var é generico no ambiente do dev, apos compilação atribui-se um tipo.
            var result = n1 + n2;
            Console.WriteLine($"A soma é {result} e resulta em um tipo {result.GetType()}");

            long n3 = 10;
            short n4 = 20;
            //Nesse caso ele pega a maior atribuição e seta para ele mesmo.
            var result2 = n3 + n4;
            Console.WriteLine($"A soma é {result2} e resulta em um tipo {result2.GetType()}");

            //Conversão explicita
            var result3 = (int)n2;
            //usando classe .net, mas tem o mesmo sentido.
            var result4 = Convert.ToInt32(n2);
            Console.WriteLine($"A soma é {result3} e resulta em um tipo {result3.GetType()}");
        }   
    }
}
