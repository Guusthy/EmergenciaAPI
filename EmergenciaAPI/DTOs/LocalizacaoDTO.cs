namespace EmergenciaAPI.DTOs
{
    public class LocalizacaoDTO
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DataHora { get; set; }

        public int UsuarioId { get; set; }
    }
}
