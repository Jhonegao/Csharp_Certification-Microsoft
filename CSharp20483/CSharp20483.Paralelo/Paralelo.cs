using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Paralelo
{
    public class Paralelo
    {
        public void Executa()
        {
            ChamadaSequencial();
            ChamadaParalela();
        }
        private void ChamadaParalela()
        {
            Console.WriteLine("Chamada de método paralelo");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.Invoke(
                            () => Envia.Email(),
                            () => Envia.Carta()
                            );

            sw.Stop();
            var tempo = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Executado transmissões em paralelo com sucesso em : {tempo} s");
        }
        private void ChamadaSequencial()
        {
            Console.WriteLine("Chamada de método sequencial");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Envia.Email();
            Envia.Carta();
            sw.Stop();
            var tempo = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Executado transmissões com sucesso em : {tempo} s");
        }
    }
}
