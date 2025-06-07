namespace EmergenciaAPI.DTOs
{
    public class AlertaDTO
    {
        public string Tipo { get; set; }
        public string Nivel { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataHora { get; set; }

        public int DispositivoId { get; set; }
    }
}
