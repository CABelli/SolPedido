using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SolPedido.Dominio.Recursos;

namespace SolPedido.Dominio.ValorObjetos
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(X => X.Endereco, Mensagem.XO_INVALIDO.ToFormat("E-Mail"));
        }

        public string Endereco { get; private set; }
    }
}
