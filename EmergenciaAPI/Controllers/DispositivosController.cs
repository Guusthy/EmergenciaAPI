using Microsoft.AspNetCore.Mvc;
using EmergenciaAPI.Models;
using EmergenciaAPI.DTOs;

namespace EmergenciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivosController : ControllerBase
    {
        private static List<Dispositivo> dispositivos = new List<Dispositivo>();

        [HttpGet]
        public ActionResult<IEnumerable<Dispositivo>> Get() => Ok(dispositivos);

        [HttpPost]
        public ActionResult<Dispositivo> Post([FromBody] DispositivoDTO dto)
        {
            var dispositivo = new Dispositivo
            {
                Id = dispositivos.Count + 1,
                Nome = dto.Nome,
                Tipo = dto.Tipo,
                UsuarioId = dto.UsuarioId
            };
            dispositivos.Add(dispositivo);
            return CreatedAtAction(nameof(Get), new { id = dispositivo.Id }, dispositivo);
        }
    }
}
