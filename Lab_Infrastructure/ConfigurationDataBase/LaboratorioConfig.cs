using Lab_Domain.Entities;
using Lab_Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Infrastructure.ConfigurationDataBase
{
    internal class LaboratorioConfig : IEntityTypeConfiguration<Laboratorio>
    {
        public void Configure(EntityTypeBuilder<Laboratorio> builder)
        {
            builder.ToTable("TB_Laboratorio", "dbo");
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
                .HasColumnName("CL_Cadeado")
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.NomeTecnico)
                .HasColumnName("CL_Tecnico")
                .HasDefaultValue("laboratorio")
                .HasMaxLength(180)
                .IsRequired();

            builder.Property(x => x.Entrada)
                .HasColumnName("CL_Entrada");

            builder.Property(x => x.Saida)
                .HasColumnName("CL_Saida");

            builder.Property(x => x.Armario)
                .HasColumnName("CL_Armario")
                .HasMaxLength(1)
                .HasConversion(x => x.ToString(),
                x => (EnumArmario)Enum.Parse(typeof(EnumArmario), x));

            builder.Property(x => x.Observacao)
                .HasColumnName("CL_Observacao")
                .HasMaxLength(200);
        }
    }
}