﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.MappingData
{
    internal class TecnicoMap : IEntityTypeConfiguration<TecnicoDto>
    {
        public void Configure(EntityTypeBuilder<TecnicoDto> builder)
        {
            builder.ToTable("TB_TECNICOS");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.Property(x => x.Nome)
                .HasColumnName("CL_NOME");
        }
    }
}