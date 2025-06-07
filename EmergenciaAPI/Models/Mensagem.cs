namespace EmergenciaAPI.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
        public int UsuarioId { get; set; }
    }
}
