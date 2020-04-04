using SolPedido.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SolPedido.Infra.Persistencia
{
    public class SolPedidoContexto : DbContext
    {
        public SolPedidoContexto() : base("SolPedido")
                                      // ("SolPedidoConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled   = false;
        }

        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure( p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.AddFromAssembly(typeof(SolPedidoContexto).Assembly);

            base.OnModelCreating(modelBuilder);

        }
    }
}
