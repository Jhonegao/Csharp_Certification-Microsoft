using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo4.Aula13.Eventos
{
    public class Delegados
    {
        // Delegates são ponteiros para métodos
        private delegate int Contas(int a, int b);

        public void Executa()
        {
            Contas c1 = Soma;

            var a = c1(10, 2);
            Console.WriteLine(a);
            c1 = Multiplicacao;
            a = c1(10, 2);
            Console.WriteLine(a);
        }

        private int Soma(int a, int b)
        {
            return a + b;
        }

        private int Multiplicacao(int a, int b)
        {
            return a * b;
        }
    }
}
