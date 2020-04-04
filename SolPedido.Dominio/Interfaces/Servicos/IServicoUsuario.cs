using SolPedido.Dominio.Argumentos.Base;
using SolPedido.Dominio.Argumentos.Usuario;
using SolPedido.Dominio.Interfaces.Servicos.Base;
using System;
using System.Collections.Generic;

namespace SolPedido.Dominio.Interfaces.Servicos
{
    public interface IServicoUsuario : IServicoBase 
    {
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
        
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);

        AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request);

        IEnumerable<UsuarioResponse> ListarUsuario();

        ResponseBase ExcluirUsuario(Guid id);

    }
}
