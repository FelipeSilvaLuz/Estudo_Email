using Estudo_Email.Models;
using Estudo_Email.Services;

namespace Estudo_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Email envio = new Email();

            LayoutEmail layout = new LayoutEmail
            {
                Titulo = "titulo do email",
                Assunto = "teste de assunto",
                Copia = "felipedasilvata24@gmail.com",
                Remetente = "felipedasilvata24@gmail.com",
                Destinatario = "felipedasilvata24@gmail.com"
            };

            envio.EnviarEmail(layout);
        }
    }
}