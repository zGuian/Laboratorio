﻿using Lab_Application.DTOs;
using Lab_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab_Infrastructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Registro> Registro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new TecnicoMap());
            //modelBuilder.ApplyConfiguration(new EquipamentoMap());
            //modelBuilder.ApplyConfiguration(new RegistroMap());
        }
    }
}