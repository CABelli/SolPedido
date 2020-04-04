using SolPedido.Dominio.Entidades;
using SolPedido.Dominio.ValorObjetos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SolPedido.Infra.Persistencia.Mapa
{
    public class MapaCliente : EntityTypeConfiguration<Cliente>
    {
        public MapaCliente()
        {
            ToTable("Cliente");

            Property(p => p.Nome).HasMaxLength(50).IsRequired();
        }
    }
}
