using Api.Dto;
using Api.Entities;

namespace Api.Interfaces
{
    public interface IEstudianteRepository
    {
        public Task<Estudiante?> ObtenerEstudiantePorIdAsync(int idEstudiante);
        public void RegistrarEstudiante(Estudiante estudiante);
        public void ActualizarEstudiante(Estudiante estudiante);
        public Task<bool> SaveAllChangesAsync();
    }
}
