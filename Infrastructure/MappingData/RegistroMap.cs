using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.MappingData
{
    internal class RegistroMap : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("TB_REGISTRO");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Entrada)
                .HasColumnName("CL_ENTRADA");

            builder.Property(r => r.Saida)
                .HasColumnName("CL_SAIDA");

            builder.Property(r => r.Observacao)
                .HasColumnName("CL_OBSERVACAO");
        }
    }
}
