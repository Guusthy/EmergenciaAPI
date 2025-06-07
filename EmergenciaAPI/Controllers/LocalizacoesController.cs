using Microsoft.AspNetCore.Mvc;
using EmergenciaAPI.Models;
using EmergenciaAPI.DTOs;

namespace EmergenciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalizacoesController : ControllerBase
    {
        private static List<Localizacao> localizacoes = new List<Localizacao>();

        [HttpGet]
        public ActionResult<IEnumerable<Localizacao>> Get() => Ok(localizacoes);

        [HttpPost]
        public ActionResult<Localizacao> Post([FromBody] LocalizacaoDTO dto)
        {
            var localizacao = new Localizacao
            {
                Id = localizacoes.Count + 1,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                DataHora = DateTime.Now,
                UsuarioId = dto.UsuarioId
            };
            localizacoes.Add(localizacao);
            return CreatedAtAction(nameof(Get), new { id = localizacao.Id }, localizacao);
        }
    }
}
