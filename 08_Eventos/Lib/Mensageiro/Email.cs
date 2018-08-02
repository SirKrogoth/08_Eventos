using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Eventos.Lib.Mensageiro
{
    public class Email
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine("Email enviado com suceso " + video.nome);
        }
    }
}
