using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Paralelo
{
    public class Envia
    {
        public static void Email()
        {
            Console.WriteLine("Enviando e-mail ...");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Email Enviado");
        }
        public static void Carta()
        {
            Console.WriteLine("Enviando Carta");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("Carta Enviada");
        }
    }
}
