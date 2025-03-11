namespace Api.Dto
{
    public class MateriasEstudianteDto
    {
        public string? Nombre { get; set; }
        public string? IdInstructor { get; set; }
        public TimeSpan? Horario { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime? FecCrea { get; set; }
        public string? UsuCrea { get; set; }
    }
}
