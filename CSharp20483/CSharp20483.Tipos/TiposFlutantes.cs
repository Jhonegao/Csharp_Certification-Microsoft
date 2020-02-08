using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TiposFlutantes : Aulas
    {
        public void Executar()
        {

            Console.WriteLine("Pontos Flutuante");
            //numeros muito grandes cientificos ex massa da terra 5.9722x10^24
            float earthMass = 5.9722e24f;
            Console.WriteLine($"Tipo Float {Single.MinValue} - {Single.MaxValue}");
            // 1,989 x 10^30kg
            double massSun = 1.989e30;
            Console.WriteLine($"Tipo Double {Double.MinValue} - {Double.MaxValue}");
            //deve-se declarar um m ao final, indicado para trabalhar com valores monetários
            decimal money = 10.199m;
            Console.WriteLine($"Tipo Decimal {Decimal.MinValue} - {Decimal.MaxValue}");

        }
    }
}
