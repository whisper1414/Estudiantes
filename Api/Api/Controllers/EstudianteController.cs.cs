using Api.Dto;
using Api.Entities;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudianteController(IEstudianteRepository estudianteRepository) : ControllerBase
    {
        [HttpGet("bitacora")]
        public async Task<ActionResult<Estudiante>> Obtener(int idEstudiante)
        {
            if (idEstudiante == 0)
                return BadRequest("No se proporciono un id de estudiante valido");

            Estudiante? estudiante = await estudianteRepository.ObtenerEstudiantePorIdAsync(idEstudiante);

            if (estudiante == null)
                return BadRequest("No se encontro la informacion del estudiante");

            return Ok(estudiante);
        }

        [HttpPost("registrar")]
        public async Task<ActionResult<Estudiante>> Registrar(RegistrarEstudianteDto estudiante)
        {
            if (estudiante.IdEstudiante == 0)
                return BadRequest("No se proporciono un id de estudiante valido");

            Estudiante? nuevoEstudiante = new();

            nuevoEstudiante.IdEstudiante = 0;
            nuevoEstudiante.Codigo = estudiante.Codigo;
            nuevoEstudiante.Nombres = estudiante.Nombres;
            nuevoEstudiante.Apellidos = estudiante.Apellidos;
            nuevoEstudiante.FechaNacimiento = estudiante.FechaNacimiento;
            nuevoEstudiante.Edad = estudiante.Edad;
            nuevoEstudiante.Correo = estudiante.Correo;

            estudianteRepository.RegistrarEstudiante(nuevoEstudiante);

            if (!await estudianteRepository.SaveAllChangesAsync())
                return BadRequest("Error: No se pudo actualizar el estudiante");

            return Ok(estudiante);
        }

        [HttpPut("actualizar")]
        public async Task<ActionResult<Estudiante>> Actualizar(EstudianteDto estudiante)
        {
            if (estudiante.IdEstudiante == 0)
                return BadRequest("No se proporciono un id de estudiante valido");

            Estudiante? actualizarEstudiante = await estudianteRepository.ObtenerEstudiantePorIdAsync(estudiante.IdEstudiante);

            if (actualizarEstudiante == null)
                return BadRequest("No se encontro la informacion del estudiante");

            actualizarEstudiante.Nombres = estudiante.Nombres;
            actualizarEstudiante.Apellidos = estudiante.Apellidos;
            actualizarEstudiante.FechaNacimiento = estudiante.FechaNacimiento;
            actualizarEstudiante.Edad = estudiante.Edad;
            actualizarEstudiante.Correo = estudiante.Correo;

            estudianteRepository.ActualizarEstudiante(actualizarEstudiante);

            if (!await estudianteRepository.SaveAllChangesAsync())
                return BadRequest("Error: No se pudo actualizar el estudiante");

            return Ok();
        }
    }
}
