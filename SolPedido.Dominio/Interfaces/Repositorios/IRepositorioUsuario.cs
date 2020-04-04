using SolPedido.Dominio.Entidades;
using SolPedido.Dominio.Interfaces.Repositorios.Base;
using System;

namespace SolPedido.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioUsuario: IRepositorioBase<Usuario, Guid>
    {        
    }
}
