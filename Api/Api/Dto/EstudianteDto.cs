namespace Api.Dto
{
    public class EstudianteDto
    {
        public int IdEstudiante { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateOnly FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; } = null!;
    }
}
