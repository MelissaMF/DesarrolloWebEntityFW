using Microsoft.EntityFrameworkCore;
namespace AcademiaApp.Models
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurar la relacion 1 a 1 entre estudiante y direccion
            modelBuilder.Entity<Estudiante>()
                .HasOne(u => u.Direccion)
                .WithOne(d => d.Estudiante)
                .HasForeignKey<Direccion>(d => d.EstudianteId);
        }
    }
}
