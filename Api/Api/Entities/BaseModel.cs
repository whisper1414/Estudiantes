namespace Api.Entities
{
    public class BaseModel
    {
        public string UsuCrea { get; set; } = "ApiEstudiantes";
        public DateTime FecCrea { get; set; } = DateTime.UtcNow;
    }
}
