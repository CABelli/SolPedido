using SolPedido.Dominio.Interfaces.Argumentos;

namespace SolPedido.Dominio.Argumentos.Cliente
{
    public class AutenticarClienteResponse : IResponse
    {
        public string Nome { get; set; }
    }
}
