using SolPedido.Dominio.Argumentos.Cliente;

namespace SolPedido.Dominio.Interfaces.Servicos
{
    public interface IServicoCliente
    {
        AutenticarClienteResponse AutenticarCliente(AutenticarClienteRequest request);
        AdicionarClienteResponse AdicionarCliente(AdicionarClienteRequest request);
    }
}
