namespace EmergenciaAPI.Models
{
    public class Localizacao
    {
        public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DataHora { get; set; }

        public int UsuarioId { get; set; }
    }
}
