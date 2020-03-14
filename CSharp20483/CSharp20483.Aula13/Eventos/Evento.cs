using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo4.Aula13.Eventos
{
    public class Evento
    {
        public void Executa()
        {
            Televisao tv = new Televisao();
            tv.Ligada += Aviso1;
            tv.Ligada += Aviso2;
            Console.WriteLine("Ligando a TV");
            tv.Ligar();
            tv.Ligada -= Aviso1;
            Console.WriteLine("Mudando canal da TV");
            tv.MudouCanal += Aviso1Canal;
            tv.MudarCanal();
            Console.WriteLine("Desligando a TV");
            tv.Desligada += Aviso1Desligada;
            tv.Desligar("Tv1");
        }
        private void Aviso1()
        {
            Console.WriteLine("Foi executado aviso 1");
        }
        private void Aviso2()
        {
            Console.WriteLine("Foi executado aviso 2");
        }

        private void Aviso1Canal(object sender, EventArgs args)
        {
            Console.WriteLine($"Foi executado aviso 1 de mudar canal");
        }

        private void Aviso1Desligada(object sender, TelevisaoEventArgs args)
        {
            Console.WriteLine($"Foi executado aviso 1 de desligar {args.Nome}");
        }
    }

}
