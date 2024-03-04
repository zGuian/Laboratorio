using Lab_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Infrastructure.ConfigurationDataBase
{
    internal class TecnicoConfig : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("TB_Tecnico", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("CL_Nome")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Equipamento)
                .HasColumnName("CL_EquipamentoId");
        }
    }
}
