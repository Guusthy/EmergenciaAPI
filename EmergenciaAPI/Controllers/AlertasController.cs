using Microsoft.AspNetCore.Mvc;
using EmergenciaAPI.Models;
using EmergenciaAPI.DTOs;

namespace EmergenciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        private static List<Alerta> alertas = new List<Alerta>();

        [HttpGet]
        public ActionResult<IEnumerable<Alerta>> Get() => Ok(alertas);

        [HttpPost]
        public ActionResult<Alerta> Post([FromBody] AlertaDTO dto)
        {
            var alerta = new Alerta
            {
                Id = alertas.Count + 1,
                Tipo = dto.Tipo,
                Nivel = dto.Nivel,
                Mensagem = dto.Mensagem,
                DataHora = DateTime.Now
            };
            alertas.Add(alerta);
            return CreatedAtAction(nameof(Get), new { id = alerta.Id }, alerta);
        }
    }
}
