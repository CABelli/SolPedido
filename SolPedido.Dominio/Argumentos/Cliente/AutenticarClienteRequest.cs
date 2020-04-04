using SolPedido.Dominio.Interfaces.Argumentos;
using System;

namespace SolPedido.Dominio.Argumentos.Cliente
{
    public class AutenticarClienteRequest : IRequest
    {
        public String Nome { get; set; }
    }
}
