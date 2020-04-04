using SolPedido.Dominio.Interfaces.Argumentos;
using System;

namespace SolPedido.Dominio.Argumentos.Usuario
{
    public class AdicionarUsuarioResponse : IResponse
    {

        public Guid Id { get; set; }
        public string Mensagem { get;  set; }

        public static explicit operator AdicionarUsuarioResponse(Entidades.Usuario entidade)
        {
            return new AdicionarUsuarioResponse()
            {
                Id       = entidade.Id
               ,Mensagem = "Operação com sucesso"  // OPERACAO_REALIZADA_COM_SUCESSO               
            };
        }
    }
}
