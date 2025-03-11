namespace Api.Dto
{
    public class RegistrarEstudianteDto
    {
        public int IdEstudiante { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateOnly FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; } = null!;
    }
}
