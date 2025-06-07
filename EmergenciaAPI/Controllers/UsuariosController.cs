using Microsoft.AspNetCore.Mvc;
using EmergenciaAPI.Models;
using EmergenciaAPI.DTOs;

namespace EmergenciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get() => Ok(usuarios);

        [HttpPost]
        public ActionResult<Usuario> Post([FromBody] UsuarioDTO dto)
        {
            var usuario = new Usuario
            {
                Id = usuarios.Count + 1,
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone
            };
            usuarios.Add(usuario);
            return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
        }
    }
}
