using prmToolkit.NotificationPattern;
using SolPedido.Dominio.Interfaces.Repositorios;
using SolPedido.Dominio.Interfaces.Repositorios.Base;
using SolPedido.Dominio.Interfaces.Servicos;
using SolPedido.Dominio.Servicos;
using SolPedido.Infra.Persistencia;
using SolPedido.Infra.Persistencia.Repositorios;
using SolPedido.Infra.Persistencia.Repositorios.Base;
using SolPedido.Infra.Transactions;
using System.Data.Entity;
using Unity;
using Unity.Lifetime; 

namespace SolPedido.IoC.Unity
{
    public class DependencyResolver
    {
        public static void Resolve(IUnityContainer container)
        {

            container.RegisterType<DbContext, SolPedidoContexto>(new HierarchicalLifetimeManager());

            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServicoUsuario, ServicoUsuario>(new HierarchicalLifetimeManager());
            //container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());



            //Repository
            container.RegisterType(typeof(IRepositorioBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositorioUsuario, RepositorioUsuario>(new HierarchicalLifetimeManager());
            //container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());

        }

    }
}
