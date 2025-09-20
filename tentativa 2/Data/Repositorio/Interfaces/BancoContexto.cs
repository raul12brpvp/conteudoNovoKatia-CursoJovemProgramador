using Microsoft.EntityFrameworkCore;
using tentativa_2.Data.Mapeamento;
using tentativa_2.Models;

namespace tentativa_2.Data.Repositorio.Interfaces
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
