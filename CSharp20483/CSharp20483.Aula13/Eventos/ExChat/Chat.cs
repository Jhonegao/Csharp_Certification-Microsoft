using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.Aula13.Eventos.ExChat
{
    class Chat
    {
        public event EventHandler<ChatEventArgs> MensagemEnviada;

        public void EnviaMensagem(Pessoa remetente, Pessoa destinatario, string mensagem)
        {
            List<Exception> erros = new List<Exception>();
            foreach (var item in MensagemEnviada.GetInvocationList())
            {
                
                try
                {
                    item.DynamicInvoke(this, new ChatEventArgs(remetente: remetente, destinatario: destinatario, mensagem: mensagem));
                }
                catch (Exception e)
                {
                    erros.Add(e.InnerException);
                }
            } 
            if(erros.Any())
                throw new AggregateException(erros);
        }
    }
}
