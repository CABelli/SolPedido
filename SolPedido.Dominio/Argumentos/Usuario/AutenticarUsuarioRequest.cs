using SolPedido.Dominio.Interfaces.Argumentos;
using System;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AutenticarUsuarioRequest : IRequest
    {
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}
