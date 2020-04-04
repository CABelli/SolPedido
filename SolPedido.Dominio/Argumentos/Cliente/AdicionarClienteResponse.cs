using SolPedido.Dominio.Interfaces.Argumentos;
using System;

namespace SolPedido.Dominio.Argumentos.Cliente
{
    public class AdicionarClienteResponse :IResponse
    {
        public Guid Id { get; set; }
        public string Mensagem { get; set; }
    }
}
