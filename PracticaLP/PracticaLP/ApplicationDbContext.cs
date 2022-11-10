using Microsoft.EntityFrameworkCore;
using PracticaLP.Entidades;

namespace PracticaLP
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authores { get; set; }
    }
}
