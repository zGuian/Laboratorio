﻿// <auto-generated />
using System;
using Lab_Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab_Infrastructure.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20240306115954_v2.0")]
    partial class v20
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFTS_Domain.Entities.Laboratorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Armario")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("CL_Armario");

                    b.Property<bool?>("Cadeado")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("CL_Cadeado");

                    b.Property<DateTime?>("Entrada")
                        .HasColumnType("datetime2")
                        .HasColumnName("CL_Entrada");

                    b.Property<string>("Inventario")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasDefaultValue("xXxXx")
                        .HasColumnName("CL_Inventario");

                    b.Property<string>("NomeTecnico")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)")
                        .HasDefaultValue("laboratorio")
                        .HasColumnName("CL_Tecnico");

                    b.Property<string>("Observacao")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("CL_Observacao");

                    b.Property<DateTime?>("Saida")
                        .HasColumnType("datetime2")
                        .HasColumnName("CL_Saida");

                    b.Property<string>("SerialNumber")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("CL_SerialNumber");

                    b.Property<string>("TipoEquipamento")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("CL_TipoEquipamento");

                    b.HasKey("Id");

                    b.ToTable("TB_Laboratorio", "dbo");
                });

            modelBuilder.Entity("EFTS_Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Chave")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("CL_Chave");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("CL_Nome");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("CL_Perfil");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CL_Senha");

                    b.HasKey("Id");

                    b.ToTable("TB_Usuarios", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
