using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.MappingData
{
    internal class EquipamentoMap : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("EQUIPAMENTOS");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.TipoEquipamento)
                .HasDefaultValue(0)
                .HasConversion<int>();

            builder.Property(e => e.SerialNumber)
                .HasColumnName("SERIAL NUMBER")
                .HasMaxLength(10)
                .HasDefaultValue("null");

            builder.Property(e => e.Hostname)
                .HasColumnName("HOSTNAME")
                .HasMaxLength(20);

            builder.Property(e => e.Cadeado)
                .HasColumnName("CADEADO")
                .HasMaxLength(3) 
                .HasDefaultValue(false);
        }
    }
}
