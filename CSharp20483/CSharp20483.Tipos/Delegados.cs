using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class Delegados : Aulas
    {
        public void Executar()
        {
            Console.WriteLine("Delegates");
            Console.WriteLine("Tipo de dado por referencia");
            int num = 4;
            int exp = 3;
            Expoente calcular = Quadrado;
            if (exp == 2)
            {
                calcular = Quadrado;
            }
            else
            {
                calcular = Cubo;
            }
            Console.WriteLine($"O quadrado de {num} é  {Quadrado(num)}");
            Console.WriteLine($"O Cubo de {num} é  {Cubo(num)}");
        }

        delegate int Expoente(int num);
        private int Quadrado(int num)
        {
            return num * num;
        }
        private int Cubo(int num)
        {
            return num * num * num;
        }
    }
}
