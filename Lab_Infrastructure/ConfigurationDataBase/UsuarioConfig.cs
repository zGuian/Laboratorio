using Lab_Domain.Entities;
using Lab_Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab_Infrastructure.ConfigurationDataBase
{
    internal class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_Usuarios", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("CL_Nome")
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.Chave)
                .HasColumnName("CL_Chave")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.Perfil)
                .HasColumnName("CL_Perfil")
                .HasMaxLength(25)
                .HasConversion(x => x.ToString(),
                x => (EnumPerfil)Enum.Parse(typeof(EnumPerfil), x))
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnName("CL_Senha")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
