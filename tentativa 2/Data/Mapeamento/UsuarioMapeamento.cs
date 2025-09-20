using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tentativa_2.Models;

namespace tentativa_2.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Email).HasColumnType("varchar(50)");
            builder.Property(t => t.Senha).HasColumnType("varchar(50)");

        }
    }
}