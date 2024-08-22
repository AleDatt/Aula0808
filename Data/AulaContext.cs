using Microsoft.EntityFrameworkCore;

namespace ExercicioProfMarcosGit.Data
{
    public class AulaContext : DbContext
    {
       public AulaContext(DbContextOptions<AulaContext> options) : base(options) 
       { 
       }
        public DbSet<ExercicioProfMarcosGit.Models.Cliente> Clientes { get; set; } = default!; 
    }
}
