using Api.Dto;

namespace Api.Interfaces
{
    public interface IConsultaMateriasService
    {
        public Task<List<MateriasEstudianteDto>> ConsultaMateriasAsync(string codigoEstudiante);
    }
}
