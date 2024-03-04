using Lab_Domain.Entities;
using Lab_Infrastructure.ConfigurationDataBase;
using Microsoft.EntityFrameworkCore;

namespace Lab_Infrastructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<Laboratorio> Laboratorios { get; set; }
        //public DbSet<Tecnico> Tecnicos { get; set; }
        //public DbSet<Equipamento> Equipamentos { get; set; }
        //public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LaboratorioConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            //modelBuilder.ApplyConfiguration(new TecnicoConfig());
            //modelBuilder.ApplyConfiguration(new EquipamentoConfig());
            //modelBuilder.ApplyConfiguration(new RegistroConfig());
        }
    }
}