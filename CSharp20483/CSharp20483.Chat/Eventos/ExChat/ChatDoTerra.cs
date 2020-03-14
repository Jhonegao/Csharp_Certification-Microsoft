using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20483.Modulo4.Aula13.Eventos.ExChat
{
    public class ChatDoTerra
    {
        public void Executa()
        {
            try
            {
                Pessoa p1 = new Pessoa { Nome = "Maykon", Sobrenome = "Granemann"};
                Pessoa p2 = new Pessoa { Nome = "Dyego", Sobrenome = "Granemann" };
                Chat chat = new Chat();
                chat.MensagemEnviada += RecebeMensagemGC;
                chat.MensagemEnviada += RecebeMensagemGF;
                chat.EnviaMensagem(p1,p2, "Ola");
                chat.EnviaMensagem(p2, p1, "Tchau");
            }
            catch (AggregateException ae)
            {
                foreach (var erro in ae.InnerExceptions)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RecebeMensagemGC(object sender, ChatEventArgs args)
        {
            Console.WriteLine($"Grupo da Cerveja - {args.Remetente.Nome} enviou {args.Mensagem} para {args.Destinatario.Nome}");
            throw new Exception("Erro ao entregar a mensagem no grupo da cerveja");
        }
        private void RecebeMensagemGF(object sender, ChatEventArgs args)
        {
            Console.WriteLine($"Grupo do Futebol - {args.Remetente.Nome} enviou {args.Mensagem} para {args.Destinatario.Nome}");
            throw new Exception("Erro ao entregar a mensagem no grupo do futebol");
        }
    }
}
