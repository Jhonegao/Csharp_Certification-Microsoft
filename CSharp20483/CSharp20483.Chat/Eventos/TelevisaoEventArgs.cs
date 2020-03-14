using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo4.Aula13.Eventos
{
    public class TelevisaoEventArgs : EventArgs
    {
        public TelevisaoEventArgs(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
    }
}
