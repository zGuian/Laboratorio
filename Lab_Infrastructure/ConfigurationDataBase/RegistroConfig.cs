using Lab_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Infrastructure.ConfigurationDataBase
{
    internal class RegistroConfig : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("TB_Registro", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Entrada)
                .HasColumnName("CL_Entrada")
                .HasColumnType("datetime")
                .HasDefaultValueSql("CONVERT(datetime, '0001-01-01T00:00:00')");

            builder.Property(x => x.Saida)
                .HasColumnName("CL_Saida")
                .HasColumnType("datetime")
                .HasDefaultValueSql("CONVERT(datetime, '0001-01-01T00:00:00')");

            builder.Property(x => x.Observacao)
                .HasColumnName("CL_Observação")
                .HasMaxLength(180);
        }
    }
}
