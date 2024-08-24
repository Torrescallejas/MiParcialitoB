using Microsoft.EntityFrameworkCore;


namespace MiParcialitoB.Models
{
    public class DBContextClass : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=qa.negociostecnologicos.net;database=Products-TC100321;user=desarrolloWebUfg;password=<BTj$jrrLV2~-4Yp1vT-",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de las llaves primarias compuestas y relaciones
            modelBuilder.Entity<Inscripcion>()
                .HasKey(i => new { i.EstudianteID, i.CursoID });

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.EstudianteID);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripciones)
                .HasForeignKey(i => i.CursoID);
        }
    }
}
