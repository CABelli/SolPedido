using SolPedido.Dominio.Interfaces.Argumentos;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AdicionarUsuarioRequest : IRequest
    {        
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }
    }
}
