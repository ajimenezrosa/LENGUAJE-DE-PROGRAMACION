namespace PracticaLP
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(options)
        {
        }
    }
}
