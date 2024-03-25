using EFTS_Domain.Entities;
using EFTS_Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Infrastructure.ConfigurationDataBase
{
    internal class EquipamentoConfig : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("TB_Equipamento", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TipoEquipamento)
                .HasColumnName("CL_TipoEquipamento")
                .HasMaxLength(1)
                .HasConversion(x => x.ToString(),
                x => (EnumTipoEquipamento)Enum.Parse(typeof(EnumTipoEquipamento), x))
                .IsRequired();

            builder.Property(x => x.SerialNumber)
                .HasColumnName("CL_SerialNumber")
                .HasMaxLength(80);

            builder.Property(x => x.Inventario)
                .HasColumnName("CL_Inventario")
                .HasDefaultValue("xXxXx")
                .HasMaxLength(120);

            builder.Property(x => x.Cadeado)
                .HasColumnName("CL_Cadeado");

            builder.Property(x => x.RegistroId)
                .HasColumnName("CL_RegistroId");
        }
    }
}