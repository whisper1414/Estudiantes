namespace Api.Entities
{
    public class MateriasEstudiante : BaseModel
    {
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }

        public Estudiante EstudianteNavigation { get; set; } = null!;
        public Materia MateriaNavigation { get; set; } = null!;
    }
}
