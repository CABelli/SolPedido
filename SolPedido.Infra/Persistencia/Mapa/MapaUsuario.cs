using SolPedido.Dominio.Entidades;
using SolPedido.Dominio.ValorObjetos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SolPedido.Infra.Persistencia.Mapa
{
    public class MapaUsuario : EntityTypeConfiguration<Usuario>
    {
        public MapaUsuario()
        {
            ToTable("Usuario");

            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_USUARIO_EMAIL") { IsUnique = true })).HasColumnName("Email");
            Property(p => p.Nome.PrimeiroNome).HasMaxLength(50).IsRequired().HasColumnName("PrimeiroNome");
            Property(p => p.Nome.UltimoNome).HasMaxLength(50).IsRequired().HasColumnName("UltimoNome");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();
        }
    }
}
