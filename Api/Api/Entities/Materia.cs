namespace Api.Entities
{
    public class Materia : BaseModel
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdInstructor { get; set; }
        public TimeSpan Horario { get; set; }
        public string Ubicacion { get; set; } = null!;

        public List<Estudiante> EstuditesNavigation { get; set; } = null!;
    }
}
