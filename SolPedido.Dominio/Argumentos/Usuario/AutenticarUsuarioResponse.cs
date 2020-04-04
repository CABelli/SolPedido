using SolPedido.Dominio.Interfaces.Argumentos;
using System;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AutenticarUsuarioResponse : IResponse
    {
        public String PrimeiroNome { get; set; }

        public String Email { get; set; }

        public int Status { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entidades.Usuario usuario)
        {
            return new AutenticarUsuarioResponse()
            {
                 Email        = usuario.Email.Endereco
                ,PrimeiroNome = usuario.Nome.PrimeiroNome
                ,Status       = (int)usuario.Status
            };
            throw new NotImplementedException();
        }
    }
}
