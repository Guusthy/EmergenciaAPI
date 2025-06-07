using Microsoft.EntityFrameworkCore;
using EmergenciaAPI.Models; 

namespace EmergenciaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
    }
}
