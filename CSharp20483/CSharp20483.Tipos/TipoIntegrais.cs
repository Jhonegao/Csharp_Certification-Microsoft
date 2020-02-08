using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Tipos
{
    public class TipoIntegrais
    {
        public void Executar()
        { 
            Console.WriteLine("Tipo Integrais");
            int num1 = 10;
            Console.WriteLine($"Inteiros 32 {Int32.MinValue} - {Int32.MaxValue} ");
            byte numB = 4;
            Console.WriteLine($"Byte {Byte.MinValue} - {Byte.MaxValue} ");
            sbyte numsB = -10;
            Console.WriteLine($"SByte {SByte.MinValue} - {SByte.MaxValue} ");
            short numS = 10;
            //int16 e short sao o mesmo dado.
            Console.WriteLine($"Short {Int16.MinValue} - {short.MaxValue} ");
            ushort numUS = 10;
            //ushort sem valores negativos mesmo vale para int32 e long
            Console.WriteLine($"Ushort unsigned {UInt16.MinValue} - {ushort.MaxValue} ");
            long numL = 1000;
            Console.WriteLine($"Long {Int64.MinValue} - {long.MaxValue} ");

            //internamente é um inteiro , deve ser declarado com aspas simples, pois duplas é string
            char letra = 'c';
            Console.WriteLine($"Tipo char {Char.MinValue} - {char.MaxValue}");
        }
    }
}
