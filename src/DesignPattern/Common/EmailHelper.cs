using System.Net;
using System.Net.Mail;

namespace Common
{
    public sealed class EmailHelper
    {
        public static void Enviar(string de_, string para_, string assunto_, string mensagem_)
        {
            var servidor = new SmtpClient("smtp.gmail.com.br", 587);
            servidor.Credentials = new NetworkCredential("aula.padroes@gmail.com", "padroes123");
            servidor.EnableSsl = true;

            var novoEmail = new MailMessage(de_, para_)
            {
                Subject = assunto_,
                Body = mensagem_
            };
            servidor.Send(novoEmail);
        }

    }
}