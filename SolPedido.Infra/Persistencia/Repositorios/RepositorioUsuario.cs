using SolPedido.Dominio.Entidades;
using SolPedido.Dominio.Interfaces.Repositorios;
using System;
using SolPedido.Infra.Persistencia.Repositorios.Base;

namespace SolPedido.Infra.Persistencia.Repositorios
{
    public class RepositorioUsuario : RepositoryBase<Usuario, Guid>, IRepositorioUsuario
    {
        protected readonly SolPedidoContexto _contexto;

        public RepositorioUsuario(SolPedidoContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
                
    }
}
