using prmToolkit.NotificationPattern;
using SolPedido.Dominio.Argumentos.Usuario;
using SolPedido.Dominio.Servicos;
using System;
using System.Linq;

namespace SolPedido.AppConsole
{
    public class Program : Notifiable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando");

            var servico = new ServicoUsuario();
            Console.WriteLine("Criei instancia do serviço ...");

            AutenticarUsuarioRequest autenticarRequest = new AutenticarUsuarioRequest();
            Console.WriteLine("Criei instancia do objeto  ...");
            autenticarRequest.Email = "cesar.belli@cesarbelli.com";
            autenticarRequest.Senha = "1234567";
            var AutenticarResponse = servico.AutenticarUsuario(autenticarRequest);
            if (servico.IsValid())
            {
                Console.WriteLine("retorno Ok   AutenticarUsuario ..." + AutenticarResponse + " => " + servico.IsValid());
            }
            else
            {
                Console.WriteLine("retorno Erro AutenticarUsuario ..." + AutenticarResponse + " => " + servico.IsValid());

            }

            ///////
            var request = new AdicionarUsuarioRequest()
            {
                Email = "cesar.belli@cesarbelli.com",
                PrimeiroNome = "Cesar",
                UltimoNome = "Belli",
                Senha = "1234567"
            };

            Console.WriteLine("Criei instancia do objeto  ...");

            var response = servico.AdicionarUsuario(request);

            if (servico.IsValid())
            { Console.WriteLine("retorno Ok   AutenticarUsuario ..." + response + " => " + servico.IsValid());
            } else
            { Console.WriteLine("retorno Erro AutenticarUsuario ..." + response + " => " + servico.IsValid());

            }

            servico.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();

        }
    }
}
