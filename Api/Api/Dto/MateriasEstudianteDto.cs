using Microsoft.EntityFrameworkCore;

namespace Api.Dto
{
    [Keyless]
    public class MateriasEstudianteDto
    {
        public string? Nombre { get; set; }
        public int? IdInstructor { get; set; }
        public TimeSpan? Horario { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime? FecCrea { get; set; }
        public string? UsuCrea { get; set; }
    }
}
