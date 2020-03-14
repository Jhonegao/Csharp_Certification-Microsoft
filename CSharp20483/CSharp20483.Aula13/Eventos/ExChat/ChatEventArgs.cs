using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Aula13.Eventos.ExChat
{
    class ChatEventArgs : EventArgs
    {
        public ChatEventArgs(string mensagem, Pessoa remetente, Pessoa destinatario)
        {
            Mensagem = mensagem;
            Remetente = remetente;
            Destinatario = destinatario;
        }

        public string Mensagem { get;}
        public Pessoa Remetente { get;}
        public Pessoa Destinatario { get;}
    }
}
