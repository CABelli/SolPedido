using SolPedido.Api.Controles;
using SolPedido.Dominio.Argumentos.Usuario;
using SolPedido.Dominio.Interfaces.Servicos;
using SolPedido.Infra.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SolPedido.Api.Controller
{


   [RoutePrefix("api/usuario")]
   // [RoutePrefix("usuario")]

    public class UsuarioController : ControleBase
    {
        private readonly IServicoUsuario _servicoUsuario;

        public UsuarioController(IUnitOfWork unitOfWork, IServicoUsuario servicoUsuario) : base(unitOfWork)
        {
            _servicoUsuario = servicoUsuario;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarUsuarioRequest request)
        {
            try
            {
                var response = _servicoUsuario.AdicionarUsuario(request);

                return await ResponseAsync(response, _servicoUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicoUsuario.ListarUsuario();

                return await ResponseAsync(response, _servicoUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

    }
}