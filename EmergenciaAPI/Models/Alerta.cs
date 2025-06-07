namespace EmergenciaAPI.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nivel { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataHora { get; set; }

        public int DispositivoId { get; set; }
    }
}
