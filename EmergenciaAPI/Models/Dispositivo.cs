namespace EmergenciaAPI.Models;

public class Dispositivo
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; } 
    public int UsuarioId { get; set; }
}
