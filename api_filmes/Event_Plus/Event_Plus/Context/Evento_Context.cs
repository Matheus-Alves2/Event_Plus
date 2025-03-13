using Event_plus.Domains;
using Event_Plus.Domains;
using EventPlus_.Domains;
using Microsoft.EntityFrameworkCore;

namespace Event_Plus.Context
{
    public class Evento_Context : DbContext
    {
        public Evento_Context()
        { 
        }

        public Evento_Context (DbContextOptions<Evento_Context> options) : base(options) 
        {
        }
        public DbSet<ComentariosEventos> ComentariosEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<Presenca> Presenca { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = NOTE25-S28\\SQLEXPRESS; Database = Event_Plus; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
