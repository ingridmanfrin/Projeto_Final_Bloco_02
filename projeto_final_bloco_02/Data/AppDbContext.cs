using Microsoft.EntityFrameworkCore;

namespace projeto_final_bloco_02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            this.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}
