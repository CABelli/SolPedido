using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class UsuarioResponse
    {
        public Guid Id { get; private set; }

        public string NomeCompleto { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public string Email { get; private set; }
        public string Status { get; private set; }

        public static explicit operator UsuarioResponse(Entidades.Usuario entidade)
        {
            return new UsuarioResponse()
            {
                  Email = entidade.Email.Endereco
                , PrimeiroNome = entidade.Nome.PrimeiroNome
                , UltimoNome = entidade.Nome.UltimoNome
                , Id = entidade.Id
                , NomeCompleto = entidade.Nome.PrimeiroNome + " " + entidade.Nome.UltimoNome
                , Status = entidade.Status.ToString()
            };
        }
    }
}
