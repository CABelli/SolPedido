//using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using SolPedido.Dominio.Interfaces.Servicos;
using Unity;
using SolPedido.Dominio.Argumentos.Usuario;
using Microsoft.Owin.Security.OAuth;

namespace SolPedido.Api.Security
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        private readonly UnityContainer _container;

        public AuthorizationProvider(UnityContainer container)
        {
            _container = container;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                IServicoUsuario servicoUsuario = _container.Resolve<IServicoUsuario>();


                AutenticarUsuarioRequest request = new AutenticarUsuarioRequest();
                request.Email = context.UserName;
                request.Senha = context.Password;

                AutenticarUsuarioResponse response = servicoUsuario.AutenticarUsuario(request);



                if (servicoUsuario.IsInvalid())
                {
                    if (response == null)
                    {
                        context.SetError("invalid_grant", "Preencha um e-mail válido e uma senha com pelo menos 6 caracteres.");
                        return;
                    }
                }

                servicoUsuario.ClearNotifications();

                if (response == null)
                {
                    context.SetError("invalid_grant", "Usuario não encontrado!");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                //Definindo as Claims
                identity.AddClaim(new Claim("Usuario", JsonConvert.SerializeObject(response)));

                var principal = new GenericPrincipal(identity, new string[] { });

                Thread.CurrentPrincipal = principal;

                context.Validated(identity);
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", ex.Message);
                return;
            }
        }
    }
}