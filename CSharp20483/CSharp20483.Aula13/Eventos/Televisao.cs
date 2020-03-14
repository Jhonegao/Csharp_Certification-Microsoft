using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo4.Aula13.Eventos
{
    public class Televisao
    {
        public Action Ligada { get; set; }

        public event EventHandler MudouCanal;

        public event EventHandler<TelevisaoEventArgs> Desligada;

        public void Ligar()
        {
            if(Ligada != null)            
                Ligada();  
        }
        public void MudarCanal()
        {
            if (MudouCanal != null)
                MudouCanal(this, new EventArgs());
        }
        public void Desligar(string nome)
        {
            if (Desligada != null)
                Desligada(this, new TelevisaoEventArgs(nome) );
        }
    }
}
