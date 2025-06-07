using Microsoft.AspNetCore.Mvc;
using EmergenciaAPI.Models;
using EmergenciaAPI.DTOs;

namespace EmergenciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MensagensController : ControllerBase
    {
        private static List<Mensagem> mensagens = new List<Mensagem>();

        [HttpGet]
        public ActionResult<IEnumerable<Mensagem>> Get() => Ok(mensagens);

        [HttpPost]
        public ActionResult<Mensagem> Post([FromBody] MensagemDTO dto)
        {
            var mensagem = new Mensagem
            {
                Id = mensagens.Count + 1,
                Conteudo = dto.Conteudo,
                DataHora = DateTime.Now,
                UsuarioId = dto.UsuarioId
            };
            mensagens.Add(mensagem);
            return CreatedAtAction(nameof(Get), new { id = mensagem.Id }, mensagem);
        }
    }
}
