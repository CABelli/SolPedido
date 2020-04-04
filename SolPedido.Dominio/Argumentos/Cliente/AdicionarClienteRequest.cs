using SolPedido.Dominio.Interfaces.Argumentos;
using SolPedido.Dominio.ValorObjetos;

namespace SolPedido.Dominio.Argumentos.Cliente
{
    public class AdicionarClienteRequest : IRequest
    {
        public Nome Nome { get; set; }
    }
}
