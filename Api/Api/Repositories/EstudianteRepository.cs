using Api.Data;
using Api.Entities;
using Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class EstudianteRepository(DataContext context) : IEstudianteRepository
    {
        public async Task<Estudiante?> ObtenerEstudiantePorIdAsync(int idEstudiante)
        {
            return await context.Estudiantes
                .Where(x => x.IdEstudiante == idEstudiante)
                .SingleOrDefaultAsync();
        }

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            context.Add(estudiante);
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            context.Update(estudiante);
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
