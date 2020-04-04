using SolPedido.Dominio.Argumentos.Cliente;

namespace SolPedido.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioCliente
    {
        AutenticarClienteResponse AutenticarCliente(AutenticarClienteRequest request);
        AdicionarClienteResponse AdicionarCliente(AdicionarClienteRequest request);
    }
}
