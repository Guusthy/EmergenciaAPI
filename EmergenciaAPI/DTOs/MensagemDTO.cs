namespace EmergenciaAPI.DTOs
{
    public class MensagemDTO
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
        public int UsuarioId { get; set; }
    }
}
