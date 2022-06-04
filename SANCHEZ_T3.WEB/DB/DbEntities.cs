using Microsoft.EntityFrameworkCore;
using SANCHEZ_T3.WEB.Models;
using SANCHEZ_T3.WEB.DB.Mapping;

namespace SANCHEZ_T3.WEB.DB
{
    public class DbEntities : DbContext
    {
        public DbSet<Dueño> dueños { get; set; }
        public DbSet<HistoriaClinica> historiaClinicas { get; set; }
        public DbSet<Mascota> mascotas { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbEntities() { }
        public DbEntities(DbContextOptions<DbEntities> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DueñoMapping());
            modelBuilder.ApplyConfiguration(new HistoriaClinicaMapping());
            modelBuilder.ApplyConfiguration(new MascotaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }
    }
}
