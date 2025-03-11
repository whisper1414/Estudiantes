using Api.Data;
using Api.Dto;
using Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
    public class ConsultaMateriasService(DataContext context) : IConsultaMateriasService
    {
        public async Task<List<MateriasEstudianteDto>> ConsultaMateriasAsync(string codigoEstudiante)
        {
            var detalleMateriasEstudiante = await context.ConsultaMateriasEstudiantes
                .FromSqlRaw("EXEC SP_MATERIAS_POR_ESTUDIANTE @CODIGO_ESTUDIANTE = {0}", codigoEstudiante)
                .ToListAsync();

            return detalleMateriasEstudiante;
        }
    }
}
