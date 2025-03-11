using Api.Dto;
using Api.Entities;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController(IConsultaMateriasService consultaMateriasService) : ControllerBase
    {
        [HttpGet(Name = "bitacora")]
        public async Task<ActionResult<Estudiante>> Obtener(string codEstudiante)
        {
            if (string.IsNullOrEmpty(codEstudiante))
                return BadRequest("No se proporciono un codigo de estudiante valido");

            List<MateriasEstudianteDto>? detalleMateriasEstudiante = await consultaMateriasService.ConsultaMateriasAsync(codEstudiante);

            if (detalleMateriasEstudiante == null)
                return BadRequest("No se encontro la informacion del estudiante");

            return Ok(detalleMateriasEstudiante);
        }
    }
}
