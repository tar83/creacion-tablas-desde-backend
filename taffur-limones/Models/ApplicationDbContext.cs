using Microsoft.EntityFrameworkCore;

namespace taffur_limones.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Genero> Generos { get; set; }
    }
}
