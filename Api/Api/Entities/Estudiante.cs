namespace Api.Entities
{
    public class Estudiante : BaseModel
    {
        public int IdEstudiante { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public DateOnly FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; } = null!;

        public List<Materia> MateriasNavigation { get; set; } = null!;
    }
}
