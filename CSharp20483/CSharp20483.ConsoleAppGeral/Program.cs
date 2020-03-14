using CSharp20483.Aula13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.ConsoleAppGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConverter js = new JsonConverter();
            js.Executa();
            Console.ReadKey();
        }
    }
}