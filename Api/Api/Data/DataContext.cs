using Api.Dto;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<MateriasEstudiante> MateriasEstudiantes { get; set; }
        public virtual DbSet<MateriasEstudianteDto> ConsultaMateriasEstudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Estudiante>()
                .HasKey(k => k.IdEstudiante);

            builder.Entity<Materia>()
                .HasKey(k => k.IdMateria);

            builder.Entity<MateriasEstudiante>()
                .HasKey(k => new { k.IdMateria, k.IdEstudiante});
            builder.Entity<MateriasEstudiante>()
                .HasOne(s => s.EstudianteNavigation)
                .WithMany()
                .HasForeignKey(s => s.IdEstudiante)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<MateriasEstudiante>()
                .HasOne(s => s.MateriaNavigation)
                .WithMany()
                .HasForeignKey(s => s.IdMateria)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
