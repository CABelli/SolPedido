namespace SolPedido.Dominio.Argumentos.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Mensagem = "OPERACAO_REALIZADA_COM_SUCESSO";  // SolPedido.Dominio.Recursos.Mensagem.OPERACAO_REALIZADA_COM_SUCESSO;


        }
        public string Mensagem  { get; set; }
    }
}
